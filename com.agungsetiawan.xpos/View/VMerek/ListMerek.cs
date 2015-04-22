using com.agungsetiawan.xpos.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com.agungsetiawan.xpos.View.VMerek
{
    public partial class ListMerek : Form
    {
        private static ListMerek form;
        private MerekService merekService;
        private ListMerek()
        {
            InitializeComponent();

            merekService = new MerekService();
            var mereks = merekService.Get();
            dataGridViewMerek.DataSource = mereks;

            dataGridViewMerek.Columns[0].Visible = false;
        }

        public static ListMerek GetForm()
        {
            if(form==null || form.IsDisposed)
            {
                form = new ListMerek();
            }

            return form;
        }

        private void dataGridViewMerek_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            byte x = 0;
            DataGridView dgv = sender as DataGridView;
            String index = (e.RowIndex + 1).ToString();
            System.Drawing.Font font = new Font("Tahoma", 8.0f, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, x);

            StringFormat centerFormat = new StringFormat();
            centerFormat.Alignment = StringAlignment.Center;
            centerFormat.LineAlignment = StringAlignment.Center;

            Rectangle headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top,
                dgv.RowHeadersWidth, e.RowBounds.Height);

            e.Graphics.DrawString(index, font, SystemBrushes.ControlText,
                headerBounds, centerFormat);
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridViewMerek.SelectedRows[0].Cells[0].Value.ToString());
            var merek = merekService.Get(id);

            DialogResult result = MessageBox.Show("Hapus data " + merek.NamaMerek + " ?", "Hapus", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                merekService.Delete(merek);
                dataGridViewMerek.DataSource = merekService.Get();
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            TambahMerek form = new TambahMerek();
            form.ParentForm = this;
            form.ShowDialog();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            UbahMerek form = new UbahMerek();
            form.ParentForm = this;
            form.PopulateData();
            form.ShowDialog();
        }
    }
}
