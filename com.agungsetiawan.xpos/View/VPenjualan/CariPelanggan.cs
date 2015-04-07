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
    public partial class CariPelanggan : Form
    {
        public TransaksiPenjualan ParentForm { get; set; }
        PelangganService pelangganService;
        public CariPelanggan()
        {
            InitializeComponent();
            this.ActiveControl = this.textBoxPelanggan;

            pelangganService = new PelangganService();
            dataGridViewCariPelanggan.DataSource = pelangganService.Get();
            dataGridViewCariPelanggan.Columns[0].Visible = false;
        }

        private void CariPelanggan_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Rectangle rectPelanggan = new Rectangle(panelPelanggan.Location.X, panelPelanggan.Location.Y,
                                                         panelPelanggan.ClientSize.Width, panelPelanggan.ClientSize.Height);

            rectPelanggan.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectPelanggan, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);
        }

        private void textBoxPelanggan_TextChanged(object sender, EventArgs e)
        {
            dataGridViewCariPelanggan.DataSource = pelangganService.FinyByNama(textBoxPelanggan.Text);
        }

        private void dataGridViewCariPelanggan_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                string id = dataGridViewCariPelanggan.SelectedRows[0].Cells[0].Value.ToString();
                Pelanggan pelanggan = pelangganService.Get(int.Parse(id));

                this.ParentForm.textBoxKodePelanggan.Text = id;
                this.ParentForm.textBoxPelanggan.Text = pelanggan.NamaPelanggan;

                DataGridView dgv=ParentForm.dataGridViewTransaksiPenjualan;
                int rowCount=dgv.Rows.Count;

                float diskon=pelanggan.Member.Diskon;
                decimal price;
                int n;
                decimal total=0;

                if(rowCount > 0)
                {
                    for(int i=0;i<rowCount-1;i++)
                    {
                        n = int.Parse(dgv.Rows[i].Cells[2].Value.ToString());
                        price = decimal.Parse(dgv.Rows[i].Cells[3].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
                        dgv.Rows[i].Cells[4].Value = diskon;
                        dgv.Rows[i].Cells[5].Value = ((price - (price * (decimal)(diskon / 100))) * n).ToString("N2", CultureInfo.GetCultureInfo("de"));

                        total += decimal.Parse(dgv.Rows[i].Cells[5].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
                    }
                }

                this.ParentForm.labelTotal.Text = total.ToString("N2", CultureInfo.GetCultureInfo("de"));
                this.ParentForm.labelTerbilang.Text = Terbilang.Bilang(total) + " Rupiah";

                this.Dispose();
            }
        }
    }
}
