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
        StokHargaUkuranService shuService;
        private TransaksiPenjualan()
        {
            InitializeComponent();

            penjualanService = new PenjualanService();
            pelangganService = new PelangganService();
            service = new BarangService();
            shuService = new StokHargaUkuranService();

            textBoxKodeTransaksi.Text=KodeTransaksiHelper.Get(penjualanService.GetKodeTransaksiTerakhir(),"J");

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

                var stockBarang=shuService.FindByBarangId(barang.Id);

                bool IsHabis=true;
                foreach(var d in stockBarang)
                {
                    if(d.Stock>0)
                    {
                        IsHabis = false;
                        break;
                    }
                }

                if(IsHabis)
                {
                    MessageBox.Show("Stok barang habis", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

 
                dataGridViewTransaksiPenjualan.Rows[row - 1].Cells[0].Value = barang.KodeBarang;
                dataGridViewTransaksiPenjualan.Rows[row - 1].Cells[1].Value = barang.NamaBarang;

                List<StokHargaUkuran> shus = shuService.FindByBarangId(barang.Id);
                DataGridViewComboBoxCell cell = new DataGridViewComboBoxCell();
                cell.DataSource = shus;
                cell.DisplayMember = "Ukuran";
                cell.ValueMember = "Ukuran";

                dataGridViewTransaksiPenjualan.Rows[row - 1].Cells[2] = cell;
                dataGridViewTransaksiPenjualan.Rows[row - 1].Cells[3].Value = 1;
                    
                //dataGridViewTransaksiPenjualan.Rows[row - 1].Cells[3].Value = barang.HargaJual.ToString("N2", CultureInfo.GetCultureInfo("de"));
                dataGridViewTransaksiPenjualan.Rows[row - 1].Cells[5].Value = diskon;
                //dataGridViewTransaksiPenjualan.Rows[row - 1].Cells[5].Value = (barang.HargaJual - (barang.HargaJual * (decimal) (diskon/100) )).ToString("N2", CultureInfo.GetCultureInfo("de"));

                dataGridViewTransaksiPenjualan.Rows.Add("", "", "", "");

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

                if (dataGridViewTransaksiPenjualan.Rows[currentRowIndex].Cells[4].Value == null)
                {
                    MessageBox.Show("Silahkan pilih ukuran", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int n = int.Parse(dataGridViewTransaksiPenjualan.Rows[currentRowIndex].Cells[3].Value.ToString());

                string id = dataGridViewTransaksiPenjualan[0, currentRowIndex].Value.ToString();

                var barang = service.FindByKodeBarang(id);
                string ukuran = (dataGridViewTransaksiPenjualan.Rows[currentRowIndex].Cells[2] as DataGridViewComboBoxCell).FormattedValue.ToString();
                var shu = shuService.FindByBarangIdAndUkuran(barang.Id, ukuran);

                if ((n + 1) > shu.Stock)
                {
                    MessageBox.Show("Stok barang tidak memadahi", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dataGridViewTransaksiPenjualan.Rows[currentRowIndex].Cells[3].Value = n + 1;

                n = int.Parse(dataGridViewTransaksiPenjualan.Rows[currentRowIndex].Cells[3].Value.ToString());
                decimal price = decimal.Parse(dataGridViewTransaksiPenjualan.Rows[currentRowIndex].Cells[4].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
                dataGridViewTransaksiPenjualan.Rows[currentRowIndex].Cells[6].Value = ((price - (price * (decimal)(diskon / 100))) * n).ToString("N2", CultureInfo.GetCultureInfo("de"));

                decimal total = 0;
                for (int i = 0; i < row-1; i++)
                {
                    total += decimal.Parse(dataGridViewTransaksiPenjualan.Rows[i].Cells[6].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
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

                int n = int.Parse(dataGridViewTransaksiPenjualan.Rows[currentRowIndex].Cells[3].Value.ToString());

                if(n==1)
                {
                    return;
                }

                dataGridViewTransaksiPenjualan.Rows[currentRowIndex].Cells[3].Value = n - 1;

                n = int.Parse(dataGridViewTransaksiPenjualan.Rows[currentRowIndex].Cells[3].Value.ToString());
                decimal price = decimal.Parse(dataGridViewTransaksiPenjualan.Rows[currentRowIndex].Cells[4].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
                dataGridViewTransaksiPenjualan.Rows[currentRowIndex].Cells[6].Value = ((price - (price * (decimal)(diskon / 100))) * n).ToString("N2", CultureInfo.GetCultureInfo("de"));

                decimal total = 0;
                for (int i = 0; i < row-1 ; i++)
                {
                    total += decimal.Parse(dataGridViewTransaksiPenjualan.Rows[i].Cells[6].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
                }

                labelTotal.Text = total.ToString("N2", CultureInfo.GetCultureInfo("de"));
                labelTerbilang.Text = Terbilang.Bilang(total) + " Rupiah";

                dataGridViewTransaksiPenjualan.Refresh();
            }

            if(e.KeyCode==Keys.Delete)
            {
                //EMANG KOMEN
                //MessageBox.Show(dataGridViewTransaksiPenjualan.CurrentCell.RowIndex.ToString());
                //return;

                int row = dataGridViewTransaksiPenjualan.Rows.Count;
                int currentRowIndex = dataGridViewTransaksiPenjualan.CurrentCell.RowIndex;

                if (row > 1 && currentRowIndex != row - 1)
                {
                    
                    dataGridViewTransaksiPenjualan.Rows.RemoveAt(currentRowIndex);
                    //EMANG KOMEN
                    //dataGridViewTransaksiPenjualan.Rows.RemoveAt(row - 2);
                    //dataGridViewTransaksiPenjualan.Rows.Add();
                }

                decimal total = 0;
                row = dataGridViewTransaksiPenjualan.Rows.Count;

                dataGridViewTransaksiPenjualan.CurrentCell = dataGridViewTransaksiPenjualan.Rows[row-1].Cells[0];
                
                for (int i = 0; i < row - 1; i++)
                {
                    total += decimal.Parse(dataGridViewTransaksiPenjualan.Rows[i].Cells[6].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
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

            //NO LONGER
            //if (e.KeyCode == Keys.F5)
            //{
            //    Pembayaran form = new Pembayaran();
            //    form.ParentForm = this;
            //    form.PopulateData();
            //    form.ShowDialog();
            //}

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
            textBoxKodeTransaksi.Text = KodeTransaksiHelper.Get(penjualanService.GetKodeTransaksiTerakhir(),"J");

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
            if(string.IsNullOrEmpty(textBoxJumlahBayar.Text))
            {
                MessageBox.Show("Jumlah bayar belum diisi", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ActiveControl = this.textBoxJumlahBayar;
                return;
            }

            decimal total = decimal.Parse(labelTotal.Text, NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
            decimal bayar = decimal.Parse(textBoxJumlahBayar.Text, NumberStyles.Number, CultureInfo.GetCultureInfo("de"));

            if(bayar<total)
            {
                MessageBox.Show("Jumlah bayar kurang", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ActiveControl = this.textBoxJumlahBayar;
                return;
            }

            DataGridView data = dataGridViewTransaksiPenjualan;

            int row = data.Rows.Count;

            if(row<=1)
            {
                MessageBox.Show("Belum ada barang yang dimasukkan", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Penjualan penjualan = new Penjualan();
            PenjualanDetail pDetail;

            for (int i = 0; i < row - 1; i++)
            {
                var kodeBarang = data.Rows[i].Cells[0].Value.ToString();
                var namaBarang = data.Rows[i].Cells[1].Value.ToString();
                string ukuran = (dataGridViewTransaksiPenjualan.Rows[i].Cells[2] as DataGridViewComboBoxCell).FormattedValue.ToString();
                var jumlahJual = int.Parse(data.Rows[i].Cells[3].Value.ToString());

                if(data.Rows[i].Cells[4].Value==null)
                {
                    MessageBox.Show("Silahkan pilih ukuran", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var hargaJual = decimal.Parse(data.Rows[i].Cells[4].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));

                var diskon = float.Parse(data.Rows[i].Cells[5].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
                var subtotal = decimal.Parse(data.Rows[i].Cells[6].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));

                var barang = service.FindByKodeBarang(kodeBarang);

                decimal hargaBeli = shuService.FindByBarangIdAndUkuran(barang.Id, ukuran).HargaBeli;

                pDetail = new PenjualanDetail()
                {
                    Penjualan = penjualan,
                    BarangId = barang.Id,
                    Ukuran=ukuran,
                    Harga = hargaJual,
                    HargaBeli=hargaBeli,
                    Jumlah = jumlahJual,
                    SubTotal = subtotal,
                    Diskon = diskon,
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

        private void dataGridViewTransaksiPenjualan_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridViewTransaksiPenjualan.CurrentCell.ColumnIndex == 2 && e.Control is ComboBox)
            {
                ComboBox comboBox = e.Control as ComboBox;
                comboBox.SelectedValueChanged += LastColumnComboSelectionChanged;
            }
        }

        private void LastColumnComboSelectionChanged(object sender, EventArgs e)
        {
            int row = dataGridViewTransaksiPenjualan.Rows.Count;

            var rowIndex = dataGridViewTransaksiPenjualan.CurrentCell.RowIndex;
            var sendingCB = sender as DataGridViewComboBoxEditingControl;
            DataGridViewTextBoxCell cel = (DataGridViewTextBoxCell)dataGridViewTransaksiPenjualan.Rows[rowIndex].Cells[4];
            var ukuran = sendingCB.EditingControlFormattedValue.ToString();

            if (string.IsNullOrEmpty(ukuran))
                return;

            var kodeBarang = dataGridViewTransaksiPenjualan.Rows[rowIndex].Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(kodeBarang))
                return;
            var barang=service.FindByKodeBarang(kodeBarang);

            var shu = shuService.FindByBarangIdAndUkuran(barang.Id, ukuran);
            if(shu==null)
            {
                return;
            }
            if ( shu.Stock < 1)
            {
                MessageBox.Show("Stok barang tidak memadahi", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridViewTransaksiPenjualan.Rows.RemoveAt(row - 1);
                dataGridViewTransaksiPenjualan.Rows.RemoveAt(row - 2);
                dataGridViewTransaksiPenjualan.Rows.Add("");
                return;
            }


            decimal harga = shuService.FindHargaByBrangIdAndUkuran(barang.Id, ukuran);
            cel.Value = harga.ToString("N2", CultureInfo.GetCultureInfo("de")); ;

            decimal hargaIndecimal=decimal.Parse(cel.Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
            float diskon = float.Parse(dataGridViewTransaksiPenjualan.Rows[rowIndex].Cells[5].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
            dataGridViewTransaksiPenjualan.Rows[rowIndex].Cells[6].Value = (hargaIndecimal - (hargaIndecimal * (decimal)(diskon / 100))).ToString("N2", CultureInfo.GetCultureInfo("de"));

           

            #region "Cek Kalau ada Kode dan Ukuran yang sama"
            //string id = dataGridViewTransaksiPenjualan[0, rowIndex].Value.ToString();
            //if (row != 1)
            //{
            //    for (int i = 0; i < row - 1; i++)
            //    {
            //        if (id == dataGridViewTransaksiPenjualan.Rows[i].Cells[0].Value.ToString()
            //            && ukuran.Equals((dataGridViewTransaksiPenjualan.Rows[i].Cells[2] as DataGridViewComboBoxCell).FormattedValue.ToString()))
            //        {
            //            if(id==dataGridViewTransaksiPenjualan[0, rowIndex].Value.ToString())
            //            {
            //                return;
            //            }

            //            int n = int.Parse(dataGridViewTransaksiPenjualan.Rows[i].Cells[3].Value.ToString());
            //            StokHargaUkuran stokHargaUkuran = shuService.FindByBarangIdAndUkuran(barang.Id, dataGridViewTransaksiPenjualan.Rows[i].Cells[2].Value.ToString());

            //            if ((n + 1) > stokHargaUkuran.Stock)
            //            {
            //                MessageBox.Show("Stok barang tidak memadahi", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                dataGridViewTransaksiPenjualan.Rows.RemoveAt(row - 1);
            //                dataGridViewTransaksiPenjualan.Rows.RemoveAt(row - 2);
            //                dataGridViewTransaksiPenjualan.Rows.Add("");
            //                return;
            //            }

            //            //dataGridViewTransaksiPenjualan.Rows[i].Cells[3].Value = n + 1;
            //            //dataGridViewTransaksiPenjualan.Rows[i].Cells[6].Value = ((decimal.Parse(dataGridViewTransaksiPenjualan.Rows[i].Cells[6].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"))) + stokHargaUkuran.HargaJual - (stokHargaUkuran.HargaJual * (decimal)(diskon / 100)))
            //            //                                                        .ToString("N2", CultureInfo.GetCultureInfo("de"));

            //            //dataGridViewTransaksiPenjualan.Rows.RemoveAt(row - 1);
            //            //dataGridViewTransaksiPenjualan.Rows.RemoveAt(row - 2);
            //            //dataGridViewTransaksiPenjualan.Rows.Add("");
            //            break;
            //        }
            //    }
            //}
            #endregion

            #region "Hitung Total dan Munculin di label dan terbilang"
            decimal total = 0;

            for (int i = 0; i < row - 1; i++)
            {
                total += decimal.Parse(dataGridViewTransaksiPenjualan.Rows[i].Cells[6].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
            }

            labelTotal.Text = total.ToString("N2", CultureInfo.GetCultureInfo("de"));
            labelTerbilang.Text = Terbilang.Bilang(total) + " Rupiah";
            #endregion
        }
    }
}
