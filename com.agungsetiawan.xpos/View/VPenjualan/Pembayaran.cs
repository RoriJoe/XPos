using com.agungsetiawan.xpos.Common;
using com.agungsetiawan.xpos.Model;
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

namespace com.agungsetiawan.xpos.View.VPenjualan
{
    public partial class Pembayaran : Form
    {
        public TransaksiPenjualan ParentForm { get; set; }
        PelangganService pelangganService;
        PenjualanService penjualanService;
        public Pembayaran()
        {
            InitializeComponent();

            pelangganService = new PelangganService();
            penjualanService = new PenjualanService();
            this.ActiveControl = textBoxJumlahBayar;
        }

        public void PopulateData()
        {
            this.labelTotal.Text = this.ParentForm.labelTotal.Text;
            decimal total = decimal.Parse(this.ParentForm.labelTotal.Text,NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
            this.labelTerbilang.Text = Terbilang.Bilang(total)+" Rupiah";
        }

        private void textBoxJumlahBayar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
            if(e.KeyChar==(char)13)
            {
                decimal total = decimal.Parse(labelTotal.Text, NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
                decimal bayar=decimal.Parse(textBoxJumlahBayar.Text);
                decimal kembali = bayar - total;
                textBoxJumlahBayar.Text = bayar.ToString("N2", CultureInfo.GetCultureInfo("de"));
                textBoxSisa.Text = kembali.ToString("N2", CultureInfo.GetCultureInfo("de"));

                this.ActiveControl = this.btnSimpan;
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DataGridView data = this.ParentForm.dataGridViewTransaksiPenjualan;

            int row = data.Rows.Count;

            Penjualan penjualan = new Penjualan();
            PenjualanDetail pDetail;

            for (int i = 0; i < row - 1; i++)
            {
                var kodeBarang = int.Parse(data.Rows[i].Cells[0].Value.ToString());
                var namaBarang = data.Rows[i].Cells[1].Value.ToString();
                var jumlahJual = int.Parse(data.Rows[i].Cells[2].Value.ToString());
                var hargaJual = decimal.Parse(data.Rows[i].Cells[3].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
                var diskon = float.Parse(data.Rows[i].Cells[4].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
                var subtotal = decimal.Parse(data.Rows[i].Cells[5].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));

                pDetail = new PenjualanDetail()
                {
                    Penjualan = penjualan,
                    BarangId = kodeBarang,
                    Harga = hargaJual,
                    Jumlah = jumlahJual,
                    SubTotal = subtotal,
                    Diskon = diskon
                };

                penjualan.PenjualanDetails.Add(pDetail);
            }

            penjualan.KodeTransaksi = this.ParentForm.textBoxKodeTransaksi.Text;
            penjualan.Tanggal = DateTime.Now;
            penjualan.TotalHargaJual = decimal.Parse(labelTotal.Text, NumberStyles.Number, CultureInfo.GetCultureInfo("de"));

            var pengguna = LoginContext.Pengguna;
            var pelanggan = pelangganService.Get(int.Parse(this.ParentForm.textBoxKodePelanggan.Text));

            penjualan.PenggunaId = pengguna.Id;
            penjualan.PelangganId = pelanggan.Id;

            penjualanService.Post(penjualan);

            this.Dispose();
            this.ParentForm.Clear();
        }

    }
}
