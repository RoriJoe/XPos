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

namespace com.agungsetiawan.xpos.View.VPelanggan
{
    public partial class ListPelanggan : Form
    {
        PelangganService pelangganService;
        static ListPelanggan form;
        private ListPelanggan()
        {
            InitializeComponent();
            pelangganService = new PelangganService();

            dataGridViewPelanggan.DataSource = pelangganService.Get();
            dataGridViewPelanggan.Columns[0].Visible = false;
        }

        public static ListPelanggan GetForm()
        {
            if (form == null || form.IsDisposed)
                form = new ListPelanggan();

            return form;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            TambahPelanggan form = new TambahPelanggan();
            form.ParentForm = this;
            form.ShowDialog();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            UbahPelanggan form = new UbahPelanggan();
            form.ParentForm = this;
            form.PopulateData();
            form.ShowDialog();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridViewPelanggan.SelectedRows[0].Cells[0].Value.ToString());
            var pelanggan = pelangganService.Get(id);

            DialogResult result = MessageBox.Show("Hapus data " + pelanggan.NamaPelanggan + " ?", "Hapus", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                pelangganService.Delete(pelanggan);
                dataGridViewPelanggan.DataSource = pelangganService.Get();
            }
        }

        private void dataGridViewPelanggan_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
