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
        private TransaksiPenjualan()
        {
            InitializeComponent();

            penjualanService = new PenjualanService();

            textBoxKodeTransaksi.Text=KodeTransaksiHelper.Get(penjualanService.GetKodeTransaksiTerakhir());

            textBoxTanggal.Text = DateTime.Today.ToString("dd MMMM yyyy", CultureInfo.GetCultureInfo("id-ID"));

            textBoxKaryawan.Text = LoginContext.Pengguna.Nama;

            dataGridViewTransaksiPenjualan.Rows.Add("", "", "", "");
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

            BarangService service = new BarangService();

            if(e.KeyCode==Keys.Enter)
            {
                int row = dataGridViewTransaksiPenjualan.Rows.Count;
                int id = int.Parse(dataGridViewTransaksiPenjualan[0, row-2].Value.ToString());
                var barang = service.Get(id);

                if(barang==null)
                {
                    MessageBox.Show("NULL");
                    return;
                }

                dataGridViewTransaksiPenjualan.Rows[row - 2].Cells[0].Value = barang.Id;
                dataGridViewTransaksiPenjualan.Rows[row - 2].Cells[1].Value = barang.NamaBarang;
                dataGridViewTransaksiPenjualan.Rows[row - 2].Cells[2].Value = 1;
                dataGridViewTransaksiPenjualan.Rows[row - 2].Cells[3].Value = barang.HargaJual.ToString("N2", CultureInfo.GetCultureInfo("de"));
                dataGridViewTransaksiPenjualan.Rows[row - 2].Cells[4].Value = 0f;
                dataGridViewTransaksiPenjualan.Rows[row - 2].Cells[5].Value = barang.HargaJual.ToString("N2", CultureInfo.GetCultureInfo("de"));

                decimal total=0;
                for (int i = 0; i < row - 1; i++)
                {
                    total += decimal.Parse(dataGridViewTransaksiPenjualan.Rows[i].Cells[5].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
                }

                labelTotal.Text = total.ToString("N2", CultureInfo.GetCultureInfo("de"));

                dataGridViewTransaksiPenjualan.Refresh();

            }

            if(e.KeyCode==Keys.F12)
            {
                int row = dataGridViewTransaksiPenjualan.Rows.Count;
                int n = int.Parse(dataGridViewTransaksiPenjualan.Rows[row - 2].Cells[2].Value.ToString());
                dataGridViewTransaksiPenjualan.Rows[row - 2].Cells[2].Value = n+1;

                n = int.Parse(dataGridViewTransaksiPenjualan.Rows[row - 2].Cells[2].Value.ToString());
                decimal price = decimal.Parse(dataGridViewTransaksiPenjualan.Rows[row - 2].Cells[3].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
                dataGridViewTransaksiPenjualan.Rows[row - 2].Cells[5].Value =(price * n).ToString("N2", CultureInfo.GetCultureInfo("de"));;

                decimal total = 0;
                for (int i = 0; i < row - 1; i++)
                {
                    total += decimal.Parse(dataGridViewTransaksiPenjualan.Rows[i].Cells[5].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
                }

                labelTotal.Text = total.ToString("N2", CultureInfo.GetCultureInfo("de"));

                dataGridViewTransaksiPenjualan.Refresh();
            }

            if (e.KeyCode == Keys.F11)
            {
                int row = dataGridViewTransaksiPenjualan.Rows.Count;
                int n = int.Parse(dataGridViewTransaksiPenjualan.Rows[row - 2].Cells[2].Value.ToString());
                dataGridViewTransaksiPenjualan.Rows[row - 2].Cells[2].Value = n - 1;

                n = int.Parse(dataGridViewTransaksiPenjualan.Rows[row - 2].Cells[2].Value.ToString());
                decimal price = decimal.Parse(dataGridViewTransaksiPenjualan.Rows[row - 2].Cells[3].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
                dataGridViewTransaksiPenjualan.Rows[row - 2].Cells[5].Value = (price * n).ToString("N2", CultureInfo.GetCultureInfo("de")); ;

                decimal total = 0;
                for (int i = 0; i < row - 1; i++)
                {
                    total += decimal.Parse(dataGridViewTransaksiPenjualan.Rows[i].Cells[5].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
                }

                labelTotal.Text = total.ToString("N2", CultureInfo.GetCultureInfo("de"));

                dataGridViewTransaksiPenjualan.Refresh();
            }

            if(e.KeyCode==Keys.Delete)
            {
                int row = dataGridViewTransaksiPenjualan.Rows.Count;
                dataGridViewTransaksiPenjualan.Rows.RemoveAt(row - 2);

                decimal total = 0;
                for (int i = 0; i < row - 2; i++)
                {
                    total += decimal.Parse(dataGridViewTransaksiPenjualan.Rows[i].Cells[5].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
                }

                labelTotal.Text = total.ToString("N2", CultureInfo.GetCultureInfo("de"));

                dataGridViewTransaksiPenjualan.Refresh();
            }

            if(e.KeyCode==Keys.F9)
            {
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
            textBoxKodePelanggan.Text = string.Empty;
            textBoxPelanggan.Text = string.Empty;
            labelTotal.Text = "0.00";
            this.ActiveControl = this.dataGridViewTransaksiPenjualan;
            dataGridViewTransaksiPenjualan.Rows.Clear();
            dataGridViewTransaksiPenjualan.CurrentCell = dataGridViewTransaksiPenjualan.Rows[0].Cells[0];
            
        }
    }
}
