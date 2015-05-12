using com.agungsetiawan.xpos.Model;
using com.agungsetiawan.xpos.ModelView;
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

namespace com.agungsetiawan.xpos.View.VLaporan
{
    public partial class LaporanKeuangan : Form
    {
        private static LaporanKeuangan form;
        private PenjualanService penjualanService;
        private PenjualanDetailService penjualanDetailService;
        private BukuBesarService bukuBesarService;
        private LaporanKeuangan()
        {
            InitializeComponent();

            penjualanService = new PenjualanService();
            penjualanDetailService = new PenjualanDetailService();
            bukuBesarService = new BukuBesarService();

            dateTimePickerTransaksiPenjualan.Format = DateTimePickerFormat.Custom;
            dateTimePickerTransaksiPenjualan.CustomFormat = "dd MMMM yyyy";

            dateTimePickerTransaksiPenjualanSampai.Format = DateTimePickerFormat.Custom;
            dateTimePickerTransaksiPenjualanSampai.CustomFormat = "dd MMMM yyyy";

            dateTimePickerBukuBesar.Format = DateTimePickerFormat.Custom;
            dateTimePickerBukuBesar.CustomFormat = "dd MMMM yyyy";

            dateTimePickerBukuBesarSampai.Format = DateTimePickerFormat.Custom;
            dateTimePickerBukuBesarSampai.CustomFormat = "dd MMMM yyyy";
        }

        public static LaporanKeuangan GetForm()
        {
            if(form==null || form.IsDisposed)
            {
                form = new LaporanKeuangan();
            }

            return form;
        }

        private void btnCetakTransaksiPenjualan_Click(object sender, EventArgs e)
        {
            TransaksiPenjualanReport report = new TransaksiPenjualanReport();

            List<PenjualanView> data;
            if(checkBoxTanggalSampai.Checked)
            {
                data = penjualanService.FindByTanggal(dateTimePickerTransaksiPenjualan.Value, dateTimePickerTransaksiPenjualanSampai.Value);
            }
            else
            {
                data = penjualanService.FindByTanggal(dateTimePickerTransaksiPenjualan.Value);
            }

            report.SetDataSource(data);

            if(data.Count<1)
            {
                MessageBox.Show("Tidak ada data ditemukan", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var dataSubReport = penjualanDetailService.GetWithBarang(data);
            report.Subreports[0].SetDataSource(dataSubReport);

            LaporanCR laporan = new LaporanCR();
            laporan.setDataReportTransaksiPenjualan(report);
            laporan.ShowDialog();
        }

        private void btnCetakBukuBesar_Click(object sender, EventArgs e)
        {
            BukuBesarReport report = new BukuBesarReport();
            List<BukuBesar> data;

            if(checkBoxTanggalSampaiBukuBesar.Checked)
            {
                data = bukuBesarService.GetByTanggal(dateTimePickerBukuBesar.Value, dateTimePickerBukuBesarSampai.Value);
            }
            else
            {
                data = bukuBesarService.GetByTanggal(dateTimePickerBukuBesar.Value);
            }

            
            report.SetDataSource(data);

            if (data.Count < 1)
            {
                MessageBox.Show("Tidak ada data ditemukan", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            decimal val = 10000000;
            report.DataDefinition.FormulaFields["SaldoAwal"].Text = val.ToString();

            LaporanCR laporan = new LaporanCR();
            laporan.setDataReportBukuBesar(report);
            laporan.ShowDialog();
        }

        private void checkBoxTanggalSampai_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxTanggalSampai.Checked)
            {
                dateTimePickerTransaksiPenjualanSampai.Visible = true;
            }
            else
            {
                dateTimePickerTransaksiPenjualanSampai.Visible = false;
            }
        }

        private void checkBoxTanggalSampaiBukuBesar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTanggalSampaiBukuBesar.Checked)
            {
                dateTimePickerBukuBesarSampai.Visible = true;
            }
            else
            {
                dateTimePickerBukuBesarSampai.Visible = false;
            }
        }
    }
}
