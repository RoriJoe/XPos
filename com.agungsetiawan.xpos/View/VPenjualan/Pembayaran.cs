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
    public partial class Pembayaran : Form
    {
        public TransaksiPenjualan ParentForm { get; set; }
        public Pembayaran()
        {
            InitializeComponent();
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
            }
        }

    }
}
