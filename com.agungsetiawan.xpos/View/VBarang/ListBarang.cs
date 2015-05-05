using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using com.agungsetiawan.xpos.Model;
using com.agungsetiawan.xpos.Repository;
using com.agungsetiawan.xpos.Service;
using com.agungsetiawan.xpos.ModelView;
using com.agungsetiawan.xpos.Report;

namespace com.agungsetiawan.xpos.View.VBarang
{
    public partial class ListBarang : Form
    {
        BarangService barangService;
        static ListBarang form;
        private StokHargaUkuranService shuService;

        private ListBarang()
        {
            InitializeComponent();
            barangService = new BarangService();
            shuService = new StokHargaUkuranService();

            var Barangs = barangService.Get();
            dataGridViewBarang.DataSource = Barangs;
            dataGridViewBarang.Columns[0].Visible = false;
        }

        public static ListBarang GetForm()
        {
            if(form==null || form.IsDisposed)
            {
                form = new ListBarang();
            }

            return form;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            TambahBarang form = new TambahBarang();
            form.ParentForm = this;
            form.ShowDialog();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            UbahBarang form = new UbahBarang();
            form.ParentForm = this;
            form.PopulateData();
            form.ShowDialog();
        }

        private void dataGridViewBarang_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            byte x=0;
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
            int id = int.Parse(dataGridViewBarang.SelectedRows[0].Cells[0].Value.ToString());
            var barang = barangService.Get(id);

            DialogResult result= MessageBox.Show("Hapus data " + barang.NamaBarang + " ?", "Hapus", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(result==DialogResult.OK)
            {
                barangService.Delete(barang);
                dataGridViewBarang.DataSource = barangService.Get();
            }
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            BarangReport barangReport = new BarangReport();

            var barangs = barangService.Get();
            barangReport.SetDataSource(barangs);

            BarangReportViewer barangReportViewer = new BarangReportViewer();
            barangReportViewer.setDataReport(barangReport);
            barangReportViewer.ShowDialog();
        }

        private void dataGridViewBarang_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewBarang.Rows.Count < 1)
                return;

            int id = 0;
            bool isValid;
            try
            {
                isValid = int.TryParse(dataGridViewBarang.SelectedRows[0].Cells[0].Value.ToString(), out id);
            }
            catch (ArgumentOutOfRangeException exception)
            {
                isValid = false;
            }


            if (!isValid || id == 0)
                return;

            dataGridViewStokUkuran.DataSource = shuService.FindByBarangId(id);
            dataGridViewStokUkuran.Columns[0].Visible = false;
            dataGridViewStokUkuran.Columns[5].Visible = false;
            dataGridViewStokUkuran.Columns[6].Visible = false;
        }
    }
}
