using com.agungsetiawan.xpos.Model;
using com.agungsetiawan.xpos.Report;
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

namespace com.agungsetiawan.xpos.View.VKategori
{
    public partial class ListKategori : Form
    {
        static ListKategori form;
        KategoriService kategoriService;
        private ListKategori()
        {
            InitializeComponent();

            kategoriService = new KategoriService();

            var Kategoris = kategoriService.Get();
            dataGridViewKategori.DataSource = Kategoris;
            dataGridViewKategori.Columns[0].Visible = false;
        }

        public static ListKategori GetForm()
        {
            if(form==null || form.IsDisposed)
            {
                form = new ListKategori();
            }

            return form;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            TambahKategori form = new TambahKategori();
            form.ParentForm = this;
            form.ShowDialog();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            UbahKategori form = new UbahKategori();
            form.ParentForm = this;
            form.PopulateData();
            form.ShowDialog();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridViewKategori.SelectedRows[0].Cells[0].Value.ToString());
            var kategori = kategoriService.Get(id);

            DialogResult result = MessageBox.Show("Hapus data " + kategori.NamaKategori + " ?", "Hapus", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                kategoriService.Delete(kategori);
                dataGridViewKategori.DataSource = kategoriService.Get();
            }
        }

        private void dataGridViewKategori_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void btnCetak_Click(object sender, EventArgs e)
        {
            var kategoris = kategoriService.Get();
            KategoriReport kategoriReport = new KategoriReport();
            kategoriReport.SetDataSource(kategoris);

            KategoriReportViewer kategoriReportViewer = new KategoriReportViewer();
            kategoriReportViewer.setDataReport(kategoriReport);
            kategoriReportViewer.ShowDialog();
        }
    }
}
