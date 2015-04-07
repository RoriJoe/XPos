using com.agungsetiawan.xpos.Common;
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
    public partial class ApplyHarga : Form
    {
        public TransaksiPenjualan ParentForm { get; set; }
        public ApplyHarga()
        {
            InitializeComponent();
        }

        private void textBoxHarga_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                decimal harga = decimal.Parse(textBoxHarga.Text);
                int row = this.ParentForm.dataGridViewTransaksiPenjualan.Rows.Count;
                this.ParentForm.dataGridViewTransaksiPenjualan.Rows[row - 2].Cells[3].Value = harga.ToString("N2", CultureInfo.GetCultureInfo("de")); ;

                int n = int.Parse(this.ParentForm.dataGridViewTransaksiPenjualan.Rows[row - 2].Cells[2].Value.ToString());
                decimal price = decimal.Parse(this.ParentForm.dataGridViewTransaksiPenjualan.Rows[row - 2].Cells[3].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
                this.ParentForm.dataGridViewTransaksiPenjualan.Rows[row - 2].Cells[5].Value = (price * n).ToString("N2", CultureInfo.GetCultureInfo("de")); ;

                decimal total = 0;
                for (int i = 0; i < row - 1; i++)
                {
                    total += decimal.Parse(this.ParentForm.dataGridViewTransaksiPenjualan.Rows[i].Cells[5].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
                }

                this.ParentForm.labelTotal.Text = total.ToString("N2", CultureInfo.GetCultureInfo("de"));
                this.ParentForm.labelTerbilang.Text = Terbilang.Bilang(total) + " Rupiah";

                this.Dispose();
            }
        }

    }
}
