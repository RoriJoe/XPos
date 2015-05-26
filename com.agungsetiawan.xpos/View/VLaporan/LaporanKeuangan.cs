using com.agungsetiawan.xpos.Model;
using com.agungsetiawan.xpos.ModelView;
using com.agungsetiawan.xpos.Report;
using com.agungsetiawan.xpos.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private PembelianService pembelianService;
        private PembelianDetailService pembelianDetailService;
        private BukuBesarService bukuBesarService;
        private LaporanKeuangan()
        {
            InitializeComponent();

            penjualanService = new PenjualanService();
            penjualanDetailService = new PenjualanDetailService();
            pembelianService = new PembelianService();
            pembelianDetailService = new PembelianDetailService();
            bukuBesarService = new BukuBesarService();

            dateTimePickerTransaksiPenjualan.Format = DateTimePickerFormat.Custom;
            dateTimePickerTransaksiPenjualan.CustomFormat = "dd MMMM yyyy";

            dateTimePickerTransaksiPenjualanSampai.Format = DateTimePickerFormat.Custom;
            dateTimePickerTransaksiPenjualanSampai.CustomFormat = "dd MMMM yyyy";

            dateTimePickerTransaksiPembelian.Format = DateTimePickerFormat.Custom;
            dateTimePickerTransaksiPembelian.CustomFormat = "dd MMMM yyyy";

            dateTimePickerTransaksiPembelianSampai.Format = DateTimePickerFormat.Custom;
            dateTimePickerTransaksiPembelianSampai.CustomFormat = "dd MMMM yyyy";

            dateTimePickerBukuBesar.Format = DateTimePickerFormat.Custom;
            dateTimePickerBukuBesar.CustomFormat = "dd MMMM yyyy";

            dateTimePickerBukuBesarSampai.Format = DateTimePickerFormat.Custom;
            dateTimePickerBukuBesarSampai.CustomFormat = "dd MMMM yyyy";

            labelTotalSaldo.Text = "Total Saldo : " + bukuBesarService.GetTotalSaldoSebelumHariIni(DateTime.Today).ToString("N2", CultureInfo.GetCultureInfo("id-ID"));
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
                data = penjualanService.FindByTanggal(dateTimePickerTransaksiPenjualan.Value.Date, dateTimePickerTransaksiPenjualanSampai.Value.Date.AddHours(23).AddMinutes(59));
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

        private void btnCetakTransaksiPembelian_Click(object sender, EventArgs e)
        {
            TransaksiPembelianReport report = new TransaksiPembelianReport();

            List<PembelianView> data=null;
            if (checkBoxTanggalSampaiTransaksiPembelian.Checked)
            {
                data = pembelianService.FindByTanggal(dateTimePickerTransaksiPembelian.Value.Date, dateTimePickerTransaksiPembelianSampai.Value.Date.AddHours(23).AddMinutes(59));
            }
            else
            {
                data = pembelianService.FindByTanggal(dateTimePickerTransaksiPembelian.Value);
            }

            report.SetDataSource(data);

            if (data.Count < 1)
            {
                MessageBox.Show("Tidak ada data ditemukan", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var dataSubReport = pembelianDetailService.GetWithBarang(data);
            report.Subreports[0].SetDataSource(dataSubReport);

            LaporanCR laporan = new LaporanCR();
            laporan.setDataReportTransaksiPembelian(report);
            laporan.ShowDialog();
        }

        private void btnCetakBukuBesar_Click(object sender, EventArgs e)
        {
            BukuBesarReport report = new BukuBesarReport();
            List<BukuBesar> data;

            if(checkBoxTanggalSampaiBukuBesar.Checked)
            {
                data = bukuBesarService.GetByTanggal(dateTimePickerBukuBesar.Value.Date, dateTimePickerBukuBesarSampai.Value.Date.AddHours(23).AddMinutes(59));
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

            decimal val = bukuBesarService.GetTotalSaldoSebelumHariIni(dateTimePickerBukuBesar.Value.Date);
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

        private void checkBoxTanggalSampaiTransaksiPembelian_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTanggalSampaiTransaksiPembelian.Checked)
            {
                dateTimePickerTransaksiPembelianSampai.Visible = true;
            }
            else
            {
                dateTimePickerTransaksiPembelianSampai.Visible = false;
            }
        }

        
    }
}
