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

namespace com.agungsetiawan.xpos.View.VPembelian
{
    public partial class TransaksiPembelian : Form
    {
        private static TransaksiPembelian form;
        private PembelianService pembelianService;
        private SupplierService supplierService;
        private BarangService service;
        private StokHargaUkuranService shuService;
        public TransaksiPembelian()
        {
            InitializeComponent();

            pembelianService = new PembelianService();
            supplierService = new SupplierService();
            service = new BarangService();
            shuService = new StokHargaUkuranService();

            textBoxKodeTransaksi.Text = KodeTransaksiHelper.Get(pembelianService.GetKodeTransaksiTerakhir(), "B");

            textBoxTanggal.Text = DateTime.Today.ToString("dd MMMM yyyy", CultureInfo.GetCultureInfo("id-ID"));

            textBoxKaryawan.Text = LoginContext.Pengguna.Nama;

            dataGridViewTransaksiPembelian.Rows.Add("", "", "", "");
        }

        public static TransaksiPembelian GetForm()
        {
            if (form == null || form.IsDisposed)
            {
                form = new TransaksiPembelian();
            }

            return form;
        }

        private void TransaksiPembelian_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Rectangle rectKodeTransaksi = new Rectangle(panelKodeTransaksi.Location.X, panelKodeTransaksi.Location.Y,
                                                          panelKodeTransaksi.ClientSize.Width, panelKodeTransaksi.ClientSize.Height);

            System.Drawing.Rectangle rectTanggal = new Rectangle(panelTanggal.Location.X, panelTanggal.Location.Y,
                                                          panelTanggal.ClientSize.Width, panelTanggal.ClientSize.Height);

            System.Drawing.Rectangle rectKaryawan = new Rectangle(panelKaryawan.Location.X, panelKaryawan.Location.Y,
                                                          panelKaryawan.ClientSize.Width, panelKaryawan.ClientSize.Height);

            System.Drawing.Rectangle rectKodeSupplier = new Rectangle(panelKodeSupplier.Location.X, panelKodeSupplier.Location.Y,
                                                         panelKodeSupplier.ClientSize.Width, panelKodeSupplier.ClientSize.Height);

            System.Drawing.Rectangle rectSupplier = new Rectangle(panelSupplier.Location.X, panelSupplier.Location.Y,
                                                         panelSupplier.ClientSize.Width, panelSupplier.ClientSize.Height);

            rectKodeTransaksi.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectKodeTransaksi, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);

            rectTanggal.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectTanggal, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);

            rectKaryawan.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectKaryawan, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);

            rectKodeSupplier.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectKodeSupplier, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);

            rectSupplier.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectSupplier, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);
        }

        private void dataGridViewTransaksiPembelian_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                int kodeSupplier;
                bool IsValidKodePelanggan = int.TryParse(textBoxKodeSupplier.Text, out kodeSupplier);

                float diskon;

                var pelanggan = supplierService.Get(kodeSupplier);

                //if (pelanggan != null)
                //    diskon = pelanggan.Member.Diskon;
                //else
                    diskon = 0;

                int row = dataGridViewTransaksiPembelian.Rows.Count;
                string id = dataGridViewTransaksiPembelian[0, row - 1].Value.ToString();

                var barang = service.FindByKodeBarang(id);

                if (barang == null)
                {
                    MessageBox.Show("Tidak ada barang dengan ID tersebut", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                dataGridViewTransaksiPembelian.Rows[row - 1].Cells[0].Value = barang.KodeBarang;
                dataGridViewTransaksiPembelian.Rows[row - 1].Cells[1].Value = barang.NamaBarang;

                List<StokHargaUkuran> shus = shuService.FindByBarangId(barang.Id);
                DataGridViewComboBoxCell cell = new DataGridViewComboBoxCell();
                cell.DataSource = shus;
                cell.DisplayMember = "Ukuran";
                cell.ValueMember = "Ukuran";

                dataGridViewTransaksiPembelian.Rows[row - 1].Cells[2] = cell;
                dataGridViewTransaksiPembelian.Rows[row - 1].Cells[3].Value = 1;

                dataGridViewTransaksiPembelian.Rows[row - 1].Cells[5].Value = diskon;

                dataGridViewTransaksiPembelian.Rows.Add("", "", "", "");

            }

            if (e.KeyCode == Keys.F12)
            {
                int kodeSupplier;
                bool IsValidKodePelanggan = int.TryParse(textBoxKodeSupplier.Text, out kodeSupplier);

                float diskon;

                var pelanggan = supplierService.Get(kodeSupplier);

                //if (pelanggan != null)
                //    diskon = pelanggan.Member.Diskon;
                //else
                    diskon = 0;

                    int row = dataGridViewTransaksiPembelian.Rows.Count;
                    int currentRowIndex = dataGridViewTransaksiPembelian.CurrentCell.RowIndex;

                if (row < 2 || currentRowIndex == row - 1)
                {
                    return;
                }

                if (dataGridViewTransaksiPembelian.Rows[currentRowIndex].Cells[4].Value == null)
                {
                    MessageBox.Show("Silahkan pilih ukuran", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int n = int.Parse(dataGridViewTransaksiPembelian.Rows[currentRowIndex].Cells[3].Value.ToString());

                string id = dataGridViewTransaksiPembelian[0, currentRowIndex].Value.ToString();

                dataGridViewTransaksiPembelian.Rows[currentRowIndex].Cells[3].Value = n + 1;

                n = int.Parse(dataGridViewTransaksiPembelian.Rows[currentRowIndex].Cells[3].Value.ToString());
                decimal price = decimal.Parse(dataGridViewTransaksiPembelian.Rows[currentRowIndex].Cells[4].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
                dataGridViewTransaksiPembelian.Rows[currentRowIndex].Cells[6].Value = ((price - (price * (decimal)(diskon / 100))) * n).ToString("N2", CultureInfo.GetCultureInfo("de"));

                decimal total = 0;
                for (int i = 0; i < row - 1; i++)
                {
                    total += decimal.Parse(dataGridViewTransaksiPembelian.Rows[i].Cells[6].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
                }

                labelTotal.Text = total.ToString("N2", CultureInfo.GetCultureInfo("de"));
                labelTerbilang.Text = Terbilang.Bilang(total) + " Rupiah";

                dataGridViewTransaksiPembelian.Refresh();
            }

            if (e.KeyCode == Keys.F11)
            {
                int kodeSupplier;
                bool IsValidKodePelanggan = int.TryParse(textBoxKodeSupplier.Text, out kodeSupplier);

                float diskon;

                var pelanggan = supplierService.Get(kodeSupplier);

                //if (pelanggan != null)
                //    diskon = pelanggan.Member.Diskon;
                //else
                    diskon = 0;

                    int row = dataGridViewTransaksiPembelian.Rows.Count;
                    int currentRowIndex = dataGridViewTransaksiPembelian.CurrentCell.RowIndex;

                if (row < 2 || currentRowIndex == row - 1)
                {
                    return;
                }

                int n = int.Parse(dataGridViewTransaksiPembelian.Rows[currentRowIndex].Cells[3].Value.ToString());

                if (n == 1)
                {
                    return;
                }

                dataGridViewTransaksiPembelian.Rows[currentRowIndex].Cells[3].Value = n - 1;

                n = int.Parse(dataGridViewTransaksiPembelian.Rows[currentRowIndex].Cells[3].Value.ToString());
                decimal price = decimal.Parse(dataGridViewTransaksiPembelian.Rows[currentRowIndex].Cells[4].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
                dataGridViewTransaksiPembelian.Rows[currentRowIndex].Cells[6].Value = ((price - (price * (decimal)(diskon / 100))) * n).ToString("N2", CultureInfo.GetCultureInfo("de"));

                decimal total = 0;
                for (int i = 0; i < row - 1; i++)
                {
                    total += decimal.Parse(dataGridViewTransaksiPembelian.Rows[i].Cells[6].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
                }

                labelTotal.Text = total.ToString("N2", CultureInfo.GetCultureInfo("de"));
                labelTerbilang.Text = Terbilang.Bilang(total) + " Rupiah";

                dataGridViewTransaksiPembelian.Refresh();
            }

            if (e.KeyCode == Keys.Delete)
            {
                
                int row = dataGridViewTransaksiPembelian.Rows.Count;
                int currentRowIndex = dataGridViewTransaksiPembelian.CurrentCell.RowIndex;

                if (row > 1 && currentRowIndex != row - 1)
                {

                    dataGridViewTransaksiPembelian.Rows.RemoveAt(currentRowIndex);
                    
                }

                decimal total = 0;
                row = dataGridViewTransaksiPembelian.Rows.Count;

                dataGridViewTransaksiPembelian.CurrentCell = dataGridViewTransaksiPembelian.Rows[row - 1].Cells[0];

                for (int i = 0; i < row - 1; i++)
                {
                    total += decimal.Parse(dataGridViewTransaksiPembelian.Rows[i].Cells[6].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
                }

                labelTotal.Text = total.ToString("N2", CultureInfo.GetCultureInfo("de"));
                labelTerbilang.Text = Terbilang.Bilang(total) + " Rupiah";

                dataGridViewTransaksiPembelian.Refresh();
            }

            if (e.KeyCode == Keys.F8)
            {
                int row = dataGridViewTransaksiPembelian.Rows.Count;
                int currentRowIndex = dataGridViewTransaksiPembelian.CurrentCell.RowIndex;

                if (row < 2 || currentRowIndex == row - 1)
                {
                    MessageBox.Show("Tidak ada barang yang dipilih", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ApplyHarga form = new ApplyHarga();
                form.ParentForm = this;
                form.ShowDialog();
            }

            if (e.KeyCode == Keys.F6)
            {
                CariSupplier form = new CariSupplier();
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

        private void dataGridViewTransaksiPembelian_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridViewTransaksiPembelian.CurrentCell.ColumnIndex == 2 && e.Control is ComboBox)
            {
                ComboBox comboBox = e.Control as ComboBox;
                comboBox.SelectedValueChanged += LastColumnComboSelectionChanged;
            }
        }

        private void LastColumnComboSelectionChanged(object sender, EventArgs e)
        {
            int row = dataGridViewTransaksiPembelian.Rows.Count;

            var rowIndex = dataGridViewTransaksiPembelian.CurrentCell.RowIndex;
            var sendingCB = sender as DataGridViewComboBoxEditingControl;
            DataGridViewTextBoxCell cel = (DataGridViewTextBoxCell)dataGridViewTransaksiPembelian.Rows[rowIndex].Cells[4];
            var ukuran = sendingCB.EditingControlFormattedValue.ToString();

            if (string.IsNullOrEmpty(ukuran))
                return;

            var kodeBarang = dataGridViewTransaksiPembelian.Rows[rowIndex].Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(kodeBarang))
                return;
            var barang = service.FindByKodeBarang(kodeBarang);

            decimal harga = shuService.FindHargaByBrangIdAndUkuran(barang.Id, ukuran);
            cel.Value = harga.ToString("N2", CultureInfo.GetCultureInfo("de")); ;

            decimal hargaIndecimal = decimal.Parse(cel.Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
            float diskon = float.Parse(dataGridViewTransaksiPembelian.Rows[rowIndex].Cells[5].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
            dataGridViewTransaksiPembelian.Rows[rowIndex].Cells[6].Value = (hargaIndecimal - (hargaIndecimal * (decimal)(diskon / 100))).ToString("N2", CultureInfo.GetCultureInfo("de"));



            #region "Hitung Total dan Munculin di label dan terbilang"
            decimal total = 0;

            for (int i = 0; i < row - 1; i++)
            {
                total += decimal.Parse(dataGridViewTransaksiPembelian.Rows[i].Cells[6].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
            }

            labelTotal.Text = total.ToString("N2", CultureInfo.GetCultureInfo("de"));
            labelTerbilang.Text = Terbilang.Bilang(total) + " Rupiah";
            #endregion
        }

        private void buttonSupplier_Click(object sender, EventArgs e)
        {
            CariSupplier form = new CariSupplier();
            form.ParentForm = this;
            form.ShowDialog();
        }

        public void Clear()
        {
            textBoxKodeTransaksi.Text = KodeTransaksiHelper.Get(pembelianService.GetKodeTransaksiTerakhir(), "B");

            labelTotal.Text = "0.00";
            textBoxJumlahBayar.Text = string.Empty;
            textBoxSisa.Text = string.Empty;
            labelTerbilang.Text = "Nol Rupiah";
            this.ActiveControl = this.dataGridViewTransaksiPembelian;
            dataGridViewTransaksiPembelian.Rows.Clear();
            dataGridViewTransaksiPembelian.Rows.Add();
            dataGridViewTransaksiPembelian.CurrentCell = dataGridViewTransaksiPembelian.Rows[0].Cells[0];

        }

        private void textBoxJumlahBayar_Leave(object sender, EventArgs e)
        {
            decimal total = decimal.Parse(labelTotal.Text, NumberStyles.Number, CultureInfo.GetCultureInfo("de"));

            if (string.IsNullOrEmpty(textBoxJumlahBayar.Text))
            {
                return;
            }

            decimal bayar = decimal.Parse(textBoxJumlahBayar.Text);
            decimal kembali = bayar - total;

            textBoxJumlahBayar.Text = bayar.ToString("N2", CultureInfo.GetCultureInfo("de"));
            textBoxSisa.Text = kembali.ToString("N2", CultureInfo.GetCultureInfo("de"));
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void textBoxJumlahBayar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxJumlahBayar.Text))
            {
                MessageBox.Show("Jumlah bayar belum diisi", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ActiveControl = this.textBoxJumlahBayar;
                return;
            }

            decimal total = decimal.Parse(labelTotal.Text, NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
            decimal bayar = decimal.Parse(textBoxJumlahBayar.Text, NumberStyles.Number, CultureInfo.GetCultureInfo("de"));

            if (bayar < total)
            {
                MessageBox.Show("Jumlah bayar kurang", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ActiveControl = this.textBoxJumlahBayar;
                return;
            }

            DataGridView data = dataGridViewTransaksiPembelian;

            int row = data.Rows.Count;

            if (row <= 1)
            {
                MessageBox.Show("Belum ada barang yang dimasukkan", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Pembelian pembelian = new Pembelian();
            PembelianDetail pDetail;

            for (int i = 0; i < row - 1; i++)
            {
                var kodeBarang = data.Rows[i].Cells[0].Value.ToString();
                var namaBarang = data.Rows[i].Cells[1].Value.ToString();
                string ukuran = (data.Rows[i].Cells[2] as DataGridViewComboBoxCell).FormattedValue.ToString();
                var jumlahJual = int.Parse(data.Rows[i].Cells[3].Value.ToString());

                if (data.Rows[i].Cells[4].Value == null)
                {
                    MessageBox.Show("Silahkan pilih ukuran", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                var hargaBeli = decimal.Parse(data.Rows[i].Cells[4].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));

                var diskon = float.Parse(data.Rows[i].Cells[5].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
                var subtotal = decimal.Parse(data.Rows[i].Cells[6].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));

                var barang = service.FindByKodeBarang(kodeBarang);

                pDetail = new PembelianDetail()
                {
                    Pembelian = pembelian,
                    BarangId = barang.Id,
                    Ukuran = ukuran,
                    Harga = hargaBeli,
                    Jumlah = jumlahJual,
                    SubTotal = subtotal,
                    Diskon = diskon,
                };

                pembelian.PembelianDetails.Add(pDetail);
            }

            pembelian.KodeTransaksi = textBoxKodeTransaksi.Text;
            pembelian.Tanggal = DateTime.Now;
            pembelian.TotalHargaBeli = decimal.Parse(labelTotal.Text, NumberStyles.Number, CultureInfo.GetCultureInfo("de"));

            var pengguna = LoginContext.Pengguna;
            var supplier = supplierService.Get(int.Parse(textBoxKodeSupplier.Text));

            pembelian.PenggunaId = pengguna.Id;
            pembelian.SupplierId = supplier.Id;

            pembelianService.Post(pembelian);

            this.Clear();
        }
    }
}
