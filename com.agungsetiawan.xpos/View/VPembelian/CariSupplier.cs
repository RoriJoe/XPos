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
    public partial class CariSupplier : Form
    {
        public TransaksiPembelian ParentForm { get; set; }
        private SupplierService supplierService;
        public CariSupplier()
        {
            InitializeComponent();
            this.ActiveControl = this.textBoxSupplier;

            supplierService = new SupplierService();
        }

        private void CariSupplier_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Rectangle rectSupplier = new Rectangle(panelSupplier.Location.X, panelSupplier.Location.Y,
                                                         panelSupplier.ClientSize.Width, panelSupplier.ClientSize.Height);

            rectSupplier.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectSupplier, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);
        }

        private void textBoxSupplier_TextChanged(object sender, EventArgs e)
        {
            dataGridViewCariSupplier.DataSource = supplierService.FindByNama(textBoxSupplier.Text);
        }

        private void dataGridViewCariSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string id = dataGridViewCariSupplier.SelectedRows[0].Cells[0].Value.ToString();
                Supplier supplier = supplierService.Get(int.Parse(id));

                this.ParentForm.textBoxKodeSupplier.Text = id;
                this.ParentForm.textBoxSupplier.Text = supplier.NamaSupplier;

                DataGridView dgv = ParentForm.dataGridViewTransaksiPembelian;
                int rowCount = dgv.Rows.Count;

                float diskon = 0;// pelanggan.Member.Diskon;
                decimal price;
                int n;
                decimal total = 0;

                if (rowCount > 0)
                {
                    for (int i = 0; i < rowCount - 1; i++)
                    {
                        n = int.Parse(dgv.Rows[i].Cells[3].Value.ToString());
                        price = decimal.Parse(dgv.Rows[i].Cells[4].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
                        dgv.Rows[i].Cells[5].Value = diskon;
                        dgv.Rows[i].Cells[6].Value = ((price - (price * (decimal)(diskon / 100))) * n).ToString("N2", CultureInfo.GetCultureInfo("de"));

                        total += decimal.Parse(dgv.Rows[i].Cells[6].Value.ToString(), NumberStyles.Number, CultureInfo.GetCultureInfo("de"));
                    }
                }

                this.ParentForm.labelTotal.Text = total.ToString("N2", CultureInfo.GetCultureInfo("de"));
                this.ParentForm.labelTerbilang.Text = Terbilang.Bilang(total) + " Rupiah";

                this.Dispose();
            }
        }
    }
}
