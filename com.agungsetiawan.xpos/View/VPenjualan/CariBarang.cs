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
        StokHargaUkuranService shuService;
        public CariBarang()
        {
            InitializeComponent();

            this.ActiveControl = this.textBoxBarang;
            barangService = new BarangService();
            shuService = new StokHargaUkuranService();
            var barangs = barangService.Get();
            dataGridViewCariBarang.DataSource = barangs;
            dataGridViewCariBarang.Columns[0].Visible = false;
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
                string id = dataGridViewCariBarang.SelectedRows[0].Cells[1].Value.ToString();
                var barang = barangService.FindByKodeBarang(id);

                var stockBarang = shuService.FindByBarangId(barang.Id);

                bool IsHabis = true;
                foreach (var d in stockBarang)
                {
                    if (d.Stock > 0)
                    {
                        IsHabis = false;
                        break;
                    }
                }

                if (IsHabis)
                {
                    MessageBox.Show("Stok barang habis", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int row = this.ParentForm.dataGridViewTransaksiPenjualan.Rows.Count;
                this.ParentForm.dataGridViewTransaksiPenjualan.Rows[row - 1].Cells[0].Value = id;

                this.Dispose();
            }
        }
    }
}
