using com.agungsetiawan.xpos.Model;
using com.agungsetiawan.xpos.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

                this.Dispose();
            }
        }
    }
}
