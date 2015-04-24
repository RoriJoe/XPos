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
    public partial class TransaksiPenjualan : Form
    {
        static TransaksiPenjualan form;
        PenjualanService penjualanService;
        PelangganService pelangganService;
        BarangService service;
        private TransaksiPenjualan()
        {
            InitializeComponent();

            penjualanService = new PenjualanService();
            pelangganService = new PelangganService();
            service = new BarangService();

            textBoxKodeTransaksi.Text=KodeTransaksiHelper.Get(penjualanService.GetKodeTransaksiTerakhir());

            textBoxTanggal.Text = DateTime.Today.ToString("dd MMMM yyyy", CultureInfo.GetCultureInfo("id-ID"));

            textBoxKaryawan.Text = LoginContext.Pengguna.Nama;

            dataGridViewTransaksiPenjualan.Rows.Add("", "", "", "");
        }

        public bool PopulateData()
        {
            bool IsTrue = true;
            var defaultPelanggan = pelangganService.FindDiskonNol();

            if (defaultPelanggan == null)
                return false;

            textBoxKodePelanggan.Text = defaultPelanggan.Id.ToString();
            textBoxPelanggan.Text = defaultPelanggan.NamaPelanggan;
            return IsTrue;
        }

        public static TransaksiPenjualan GetForm()
        {
            if(form==null || form.IsDisposed)
            {
                form = new TransaksiPenjualan();
            }

            return form;
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {

            if(e.KeyCode==Keys.Enter)
            {

                int kodePelanggan;
                bool IsValidKodePelanggan = int.TryParse(textBoxKodePelanggan.Text, out kodePelanggan);

                float diskon;

                var pelanggan = pelangganService.Get(kodePelanggan);

                if (pelanggan != null)
                    diskon = pelanggan.Member.Diskon;
                else
                    diskon = 0;

                int row = dataGridViewTransaksiPenjualan.Rows.Count;
                string id=dataGridViewTransaksiPenjualan[0, row - 1].Value.ToString();

                var barang = service.FindByKodeBarang(id);

                if (barang == null)
                {
                    MessageBox.Show("Tidak ada barang dengan ID tersebut","Pesan",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }

                if(barang.Stok==0)
                {
                    MessageBox.Show("Stok barang habis", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                bool IsNew = true;
                if(row!=1)
                {
                    for (int i = 0; i < row - 1; i++)
                    {
                        if (id == dataGridViewTransaksiPenjualan.Rows[i].Cells[0].Value.ToString())
                        {
                            int n = int.Parse(dataGridViewTransaksiPenjualan.Rows[i].Cells[2].Value.ToString());
                            if ((n + 1) > barang.Stok)
                            {
                                MessageBox.Show("Stok barang tidak memadahi", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }

                            dataGridViewTransaksiPenjualan.Rows[i].Cells[2].Value = n + 1;
                            dataGridViewTransaksiPenjualan.Rows[i].Cells[5].Value = ((decimal.Parse(dataGridViewTransaksiPenjualan.Rows[i].Cells[5].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"))) + barang.HargaJual - (barang.HargaJual * (decimal)(diskon / 100)))
                                                                                    .ToString("N2", CultureInfo.GetCultureInfo("de"));
                            IsNew = false;
                            dataGridViewTransaksiPenjualan.Rows.RemoveAt(row-1);
                            break;
                        }
                        else
                        {
                            IsNew = true;
                        }
                    }
                }

                if(IsNew)
                {
                    dataGridViewTransaksiPenjualan.Rows[row - 1].Cells[0].Value = barang.KodeBarang;
                    dataGridViewTransaksiPenjualan.Rows[row - 1].Cells[1].Value = barang.NamaBarang;
                    dataGridViewTransaksiPenjualan.Rows[row - 1].Cells[2].Value = 1;
                    dataGridViewTransaksiPenjualan.Rows[row - 1].Cells[3].Value = barang.HargaJual.ToString("N2", CultureInfo.GetCultureInfo("de"));
                    dataGridViewTransaksiPenjualan.Rows[row - 1].Cells[4].Value = diskon;
                    dataGridViewTransaksiPenjualan.Rows[row - 1].Cells[5].Value = (barang.HargaJual - (barang.HargaJual * (decimal) (diskon/100) )).ToString("N2", CultureInfo.GetCultureInfo("de"));

                    dataGridViewTransaksiPenjualan.Rows.Add("", "", "", "");
                }
                
                decimal total=0;
                //recalculate row after deletion is id is the same

                if (!IsNew)
                {
                    row = dataGridViewTransaksiPenjualan.Rows.Count;
                    dataGridViewTransaksiPenjualan.Rows.Add("", "", "", "");
                }

                for (int i = 0; i < row; i++)
                {
                    total += decimal.Parse(dataGridViewTransaksiPenjualan.Rows[i].Cells[5].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
                }

                labelTotal.Text = total.ToString("N2", CultureInfo.GetCultureInfo("de"));
                labelTerbilang.Text = Terbilang.Bilang(total) + " Rupiah";

                dataGridViewTransaksiPenjualan.Refresh();

            }

            if(e.KeyCode==Keys.F12)
            {
                int kodePelanggan;
                bool IsValidKodePelanggan = int.TryParse(textBoxKodePelanggan.Text,out kodePelanggan);

                float diskon;

                var pelanggan = pelangganService.Get(kodePelanggan);
                
                if (pelanggan != null)
                    diskon = pelanggan.Member.Diskon;
                else
                    diskon = 0;

                int row = dataGridViewTransaksiPenjualan.Rows.Count;
                int currentRowIndex = dataGridViewTransaksiPenjualan.CurrentCell.RowIndex;

                if (row < 2 || currentRowIndex==row-1)
                {
                    return;
                }

                int n = int.Parse(dataGridViewTransaksiPenjualan.Rows[currentRowIndex].Cells[2].Value.ToString());

                string id = dataGridViewTransaksiPenjualan[0, currentRowIndex].Value.ToString();

                var barang = service.FindByKodeBarang(id);

                if((n+1)>barang.Stok)
                {
                    MessageBox.Show("Stok barang tidak memadahi", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dataGridViewTransaksiPenjualan.Rows[currentRowIndex].Cells[2].Value = n + 1;

                n = int.Parse(dataGridViewTransaksiPenjualan.Rows[currentRowIndex].Cells[2].Value.ToString());
                decimal price = decimal.Parse(dataGridViewTransaksiPenjualan.Rows[currentRowIndex].Cells[3].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
                dataGridViewTransaksiPenjualan.Rows[currentRowIndex].Cells[5].Value = ((price - (price * (decimal)(diskon / 100))) * n).ToString("N2", CultureInfo.GetCultureInfo("de"));

                decimal total = 0;
                for (int i = 0; i < row-1; i++)
                {
                    total += decimal.Parse(dataGridViewTransaksiPenjualan.Rows[i].Cells[5].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
                }

                labelTotal.Text = total.ToString("N2", CultureInfo.GetCultureInfo("de"));
                labelTerbilang.Text = Terbilang.Bilang(total) + " Rupiah";

                dataGridViewTransaksiPenjualan.Refresh();
            }

            if (e.KeyCode == Keys.F11)
            {
                int kodePelanggan;
                bool IsValidKodePelanggan = int.TryParse(textBoxKodePelanggan.Text, out kodePelanggan);

                float diskon;

                var pelanggan = pelangganService.Get(kodePelanggan);

                if (pelanggan != null)
                    diskon = pelanggan.Member.Diskon;
                else
                    diskon = 0;

                int row = dataGridViewTransaksiPenjualan.Rows.Count;
                int currentRowIndex = dataGridViewTransaksiPenjualan.CurrentCell.RowIndex;

                if (row < 2 || currentRowIndex==row-1)
                {
                    return;
                }

                int n = int.Parse(dataGridViewTransaksiPenjualan.Rows[currentRowIndex].Cells[2].Value.ToString());

                if(n==1)
                {
                    return;
                }

                dataGridViewTransaksiPenjualan.Rows[currentRowIndex].Cells[2].Value = n - 1;

                n = int.Parse(dataGridViewTransaksiPenjualan.Rows[currentRowIndex].Cells[2].Value.ToString());
                decimal price = decimal.Parse(dataGridViewTransaksiPenjualan.Rows[currentRowIndex].Cells[3].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
                dataGridViewTransaksiPenjualan.Rows[currentRowIndex].Cells[5].Value = ((price - (price * (decimal)(diskon / 100))) * n).ToString("N2", CultureInfo.GetCultureInfo("de"));

                decimal total = 0;
                for (int i = 0; i < row-1 ; i++)
                {
                    total += decimal.Parse(dataGridViewTransaksiPenjualan.Rows[i].Cells[5].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
                }

                labelTotal.Text = total.ToString("N2", CultureInfo.GetCultureInfo("de"));
                labelTerbilang.Text = Terbilang.Bilang(total) + " Rupiah";

                dataGridViewTransaksiPenjualan.Refresh();
            }

            if(e.KeyCode==Keys.Delete)
            {
                //MessageBox.Show(dataGridViewTransaksiPenjualan.CurrentCell.RowIndex.ToString());
                //return;

                int row = dataGridViewTransaksiPenjualan.Rows.Count;
                int currentRowIndex = dataGridViewTransaksiPenjualan.CurrentCell.RowIndex;

                if (row > 1 && currentRowIndex != row - 1)
                {
                    
                    dataGridViewTransaksiPenjualan.Rows.RemoveAt(currentRowIndex);
                    //dataGridViewTransaksiPenjualan.Rows.RemoveAt(row - 2);
                    //dataGridViewTransaksiPenjualan.Rows.Add();
                }

                decimal total = 0;
                row = dataGridViewTransaksiPenjualan.Rows.Count;

                dataGridViewTransaksiPenjualan.CurrentCell = dataGridViewTransaksiPenjualan.Rows[row-1].Cells[0];
                
                for (int i = 0; i < row - 1; i++)
                {
                    total += decimal.Parse(dataGridViewTransaksiPenjualan.Rows[i].Cells[5].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
                }

                labelTotal.Text = total.ToString("N2", CultureInfo.GetCultureInfo("de"));
                labelTerbilang.Text = Terbilang.Bilang(total) + " Rupiah";

                dataGridViewTransaksiPenjualan.Refresh();
            }

            if(e.KeyCode==Keys.F8)
            {
                int row = dataGridViewTransaksiPenjualan.Rows.Count;
                int currentRowIndex = dataGridViewTransaksiPenjualan.CurrentCell.RowIndex;

                if (row < 2 || currentRowIndex == row - 1)
                {
                    MessageBox.Show("Tidak ada barang yang dipilih", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ApplyHarga form = new ApplyHarga();
                form.ParentForm = this;
                form.ShowDialog();
            }

            if (e.KeyCode == Keys.F5)
            {
                Pembayaran form = new Pembayaran();
                form.ParentForm = this;
                form.PopulateData();
                form.ShowDialog();
            }

            if (e.KeyCode == Keys.F6)
            {
                CariPelanggan form = new CariPelanggan();
                form.ParentForm = this;
                form.ShowDialog();
            }

            if (e.KeyCode == Keys.F7)
            {
                CariBarang form = new CariBarang();
                form.ParentForm = this;
                form.ShowDialog();
            }
        }

        private void TransaksiPenjualan_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Rectangle rectKodeTransaksi = new Rectangle(panelKodeTransaksi.Location.X, panelKodeTransaksi.Location.Y,
                                                          panelKodeTransaksi.ClientSize.Width, panelKodeTransaksi.ClientSize.Height);

            System.Drawing.Rectangle rectTanggal = new Rectangle(panelTanggal.Location.X, panelTanggal.Location.Y,
                                                          panelTanggal.ClientSize.Width, panelTanggal.ClientSize.Height);

            System.Drawing.Rectangle rectKaryawan = new Rectangle(panelKaryawan.Location.X, panelKaryawan.Location.Y,
                                                          panelKaryawan.ClientSize.Width, panelKaryawan.ClientSize.Height);

            System.Drawing.Rectangle rectKodePelanggan = new Rectangle(panelKodePelanggan.Location.X, panelKodePelanggan.Location.Y,
                                                         panelKodePelanggan.ClientSize.Width, panelKodePelanggan.ClientSize.Height);

            System.Drawing.Rectangle rectPelanggan = new Rectangle(panelPelanggan.Location.X, panelPelanggan.Location.Y,
                                                         panelPelanggan.ClientSize.Width, panelPelanggan.ClientSize.Height);

            rectKodeTransaksi.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectKodeTransaksi, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);

            rectTanggal.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectTanggal, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);

            rectKaryawan.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectKaryawan, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);

            rectKodePelanggan.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectKodePelanggan, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);

            rectPelanggan.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectPelanggan, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);
        }

        private void buttonPelanggan_Click(object sender, EventArgs e)
        {
            CariPelanggan form = new CariPelanggan();
            form.ParentForm = this;
            form.ShowDialog();
        }

        public void Clear()
        {
            textBoxKodeTransaksi.Text = KodeTransaksiHelper.Get(penjualanService.GetKodeTransaksiTerakhir());

            var IsSuccess = this.PopulateData();
            if (!IsSuccess)
            {
                MessageBox.Show("Buat terlebih dahulu Pelanggan dengan member berdiskon 0 (nol)", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            labelTotal.Text = "0.00";
            textBoxJumlahBayar.Text = string.Empty;
            textBoxSisa.Text = string.Empty;
            labelTerbilang.Text = "Nol Rupiah";
            this.ActiveControl = this.dataGridViewTransaksiPenjualan;
            dataGridViewTransaksiPenjualan.Rows.Clear();
            dataGridViewTransaksiPenjualan.Rows.Add();
            dataGridViewTransaksiPenjualan.CurrentCell = dataGridViewTransaksiPenjualan.Rows[0].Cells[0];
            
        }

        private void textBoxJumlahBayar_Leave(object sender, EventArgs e)
        {
            decimal total = decimal.Parse(labelTotal.Text, NumberStyles.Number, CultureInfo.GetCultureInfo("de"));

            if(string.IsNullOrEmpty(textBoxJumlahBayar.Text))
            {
                return;
            }

            decimal bayar = decimal.Parse(textBoxJumlahBayar.Text);
            decimal kembali = bayar - total;

            textBoxJumlahBayar.Text = bayar.ToString("N2", CultureInfo.GetCultureInfo("de"));
            textBoxSisa.Text = kembali.ToString("N2", CultureInfo.GetCultureInfo("de"));
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DataGridView data = dataGridViewTransaksiPenjualan;

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

            penjualan.KodeTransaksi = textBoxKodeTransaksi.Text;
            penjualan.Tanggal = DateTime.Now;
            penjualan.TotalHargaJual = decimal.Parse(labelTotal.Text, NumberStyles.Number, CultureInfo.GetCultureInfo("de"));

            var pengguna = LoginContext.Pengguna;
            var pelanggan = pelangganService.Get(int.Parse(textBoxKodePelanggan.Text));

            penjualan.PenggunaId = pengguna.Id;
            penjualan.PelangganId = pelanggan.Id;

            penjualanService.Post(penjualan);

            this.Clear();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void textBoxJumlahBayar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }
    }
}
