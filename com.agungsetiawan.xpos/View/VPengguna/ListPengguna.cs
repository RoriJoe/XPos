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

namespace com.agungsetiawan.xpos.View.VPengguna
{
    public partial class ListPengguna : Form
    {
        private PenggunaService penggunaService;
        private static ListPengguna form;
        private ListPengguna()
        {
            InitializeComponent();
            penggunaService = new PenggunaService();

            dataGridViewPengguna.DataSource = penggunaService.FindWithRole();
            dataGridViewPengguna.Columns[0].Visible = false;
        }

        public static ListPengguna GetForm()
        {
            if (form == null || form.IsDisposed)
                form = new ListPengguna();
            return form;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            TambahPengguna form = new TambahPengguna();
            form.ParentForm = this;
            form.ShowDialog();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            UbahPengguna form = new UbahPengguna();
            form.ParentForm = this;
            form.PopulateData();
            form.ShowDialog();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridViewPengguna.SelectedRows[0].Cells[0].Value.ToString());
            var pengguna = penggunaService.Get(id);

            DialogResult result = MessageBox.Show("Hapus data " + pengguna.Nama + " ?", "Hapus", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                penggunaService.Delete(pengguna);
                dataGridViewPengguna.DataSource = penggunaService.FindWithRole();
            }
        }

        private void dataGridViewPengguna_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
    }
}
