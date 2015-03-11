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

            var defaultPelanggan = pelangganService.FindDiskonNol();

            textBoxKodePelanggan.Text = defaultPelanggan.Id.ToString();
            textBoxPelanggan.Text = defaultPelanggan.NamaPelanggan;

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
                int id;

                bool isValidId=int.TryParse(dataGridViewTransaksiPenjualan[0, row - 1].Value.ToString(),out id);

                var barang = service.Get(id);

                if (barang == null || !isValidId)
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
                        if (id == int.Parse(dataGridViewTransaksiPenjualan.Rows[i].Cells[0].Value.ToString()))
                        {
                            dataGridViewTransaksiPenjualan.Rows[i].Cells[2].Value = (int.Parse(dataGridViewTransaksiPenjualan.Rows[i].Cells[2].Value.ToString())) + 1;
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
                    dataGridViewTransaksiPenjualan.Rows[row - 1].Cells[0].Value = barang.Id;
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

                if(row<2)
                {
                    return;
                }

                int n = int.Parse(dataGridViewTransaksiPenjualan.Rows[row - 2].Cells[2].Value.ToString());
                
                int id=int.Parse(dataGridViewTransaksiPenjualan[0, row - 2].Value.ToString());
                var barang = service.Get(id);

                if((n+1)>barang.Stok)
                {
                    MessageBox.Show("Stok barang tidak memadahi", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dataGridViewTransaksiPenjualan.Rows[row - 2].Cells[2].Value = n+1;

                n = int.Parse(dataGridViewTransaksiPenjualan.Rows[row - 2].Cells[2].Value.ToString());
                decimal price = decimal.Parse(dataGridViewTransaksiPenjualan.Rows[row - 2].Cells[3].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
                dataGridViewTransaksiPenjualan.Rows[row - 2].Cells[5].Value =((price-(price*(decimal) (diskon/100))) * n).ToString("N2", CultureInfo.GetCultureInfo("de"));

                decimal total = 0;
                for (int i = 0; i < row-1; i++)
                {
                    total += decimal.Parse(dataGridViewTransaksiPenjualan.Rows[i].Cells[5].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
                }

                labelTotal.Text = total.ToString("N2", CultureInfo.GetCultureInfo("de"));

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

                if (row < 2)
                {
                    return;
                }

                int n = int.Parse(dataGridViewTransaksiPenjualan.Rows[row - 2].Cells[2].Value.ToString());

                if(n==1)
                {
                    return;
                }

                dataGridViewTransaksiPenjualan.Rows[row - 2].Cells[2].Value = n - 1;

                n = int.Parse(dataGridViewTransaksiPenjualan.Rows[row - 2].Cells[2].Value.ToString());
                decimal price = decimal.Parse(dataGridViewTransaksiPenjualan.Rows[row - 2].Cells[3].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
                dataGridViewTransaksiPenjualan.Rows[row - 2].Cells[5].Value = ((price - (price * (decimal)(diskon / 100))) * n).ToString("N2", CultureInfo.GetCultureInfo("de"));

                decimal total = 0;
                for (int i = 0; i < row-1 ; i++)
                {
                    total += decimal.Parse(dataGridViewTransaksiPenjualan.Rows[i].Cells[5].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
                }

                labelTotal.Text = total.ToString("N2", CultureInfo.GetCultureInfo("de"));

                dataGridViewTransaksiPenjualan.Refresh();
            }

            if(e.KeyCode==Keys.Delete)
            {
                int row = dataGridViewTransaksiPenjualan.Rows.Count;
                if(row>1)
                {
                    dataGridViewTransaksiPenjualan.Rows.RemoveAt(row - 1);
                    dataGridViewTransaksiPenjualan.Rows.RemoveAt(row - 2);
                    dataGridViewTransaksiPenjualan.Rows.Add();
                }

                decimal total = 0;
                row = dataGridViewTransaksiPenjualan.Rows.Count;

                dataGridViewTransaksiPenjualan.CurrentCell = dataGridViewTransaksiPenjualan.Rows[row-1].Cells[0];
                
                for (int i = 0; i < row - 1; i++)
                {
                    total += decimal.Parse(dataGridViewTransaksiPenjualan.Rows[i].Cells[5].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
                }

                labelTotal.Text = total.ToString("N2", CultureInfo.GetCultureInfo("de"));

                dataGridViewTransaksiPenjualan.Refresh();
            }

            if(e.KeyCode==Keys.F8)
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
            textBoxKodePelanggan.Text = string.Empty;
            textBoxPelanggan.Text = string.Empty;
            labelTotal.Text = "0.00";
            this.ActiveControl = this.dataGridViewTransaksiPenjualan;
            dataGridViewTransaksiPenjualan.Rows.Clear();
            dataGridViewTransaksiPenjualan.Rows.Add();
            dataGridViewTransaksiPenjualan.CurrentCell = dataGridViewTransaksiPenjualan.Rows[0].Cells[0];
            
        }
    }
}
