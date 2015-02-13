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
    public partial class CariBarang : Form
    {
        public TransaksiPenjualan ParentForm { get; set; }
        BarangService barangService;
        public CariBarang()
        {
            InitializeComponent();

            this.ActiveControl = this.textBoxBarang;
            barangService = new BarangService();
            var barangs = barangService.Get();
            dataGridViewCariBarang.DataSource = barangs;
        }

        private void CariBarang_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Rectangle rectBarang = new Rectangle(panelBarang.Location.X, panelBarang.Location.Y,
                                                        panelBarang.ClientSize.Width, panelBarang.ClientSize.Height);

            rectBarang.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectBarang, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);
        }

        private void textBoxBarang_TextChanged(object sender, EventArgs e)
        {
            dataGridViewCariBarang.DataSource = barangService.FindByNama(textBoxBarang.Text);
        }

        private void dataGridViewCariBarang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string id = dataGridViewCariBarang.SelectedRows[0].Cells[0].Value.ToString();
                var barang = barangService.Get(int.Parse(id));

                if(barang.Stok<1)
                {
                    MessageBox.Show("Stok barang tidak memadahi", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int row = this.ParentForm.dataGridViewTransaksiPenjualan.Rows.Count;
                this.ParentForm.dataGridViewTransaksiPenjualan.Rows[row - 1].Cells[0].Value = barang.Id;

                this.Dispose();
            }
        }
    }
}
