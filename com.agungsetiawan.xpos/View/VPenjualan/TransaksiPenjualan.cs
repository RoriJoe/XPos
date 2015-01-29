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
        private TransaksiPenjualan()
        {
            InitializeComponent();
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
        }
    }
}
