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

namespace com.agungsetiawan.xpos.View.VBarang
{
    public partial class UbahBarang : Form
    {
        public ListBarang ParentForm { get; set; }

        KategoriService kategoriService;
        BarangService barangService;
        SupplierService supplierService;
        MerekService merekService;

        public UbahBarang()
        {
            InitializeComponent();
            this.ActiveControl = this.textBoxNamaBarang;

            kategoriService = new KategoriService();
            barangService = new BarangService();
            supplierService = new SupplierService();
            merekService = new MerekService();

            var kategoris = kategoriService.Get();
            comboBoxKategori.DataSource = kategoris;
            comboBoxKategori.ValueMember = "Id";
            comboBoxKategori.DisplayMember = "NamaKategori";

            var suppliers = supplierService.Get();
            comboBoxSupplier.DataSource = suppliers;
            comboBoxSupplier.ValueMember = "Id";
            comboBoxSupplier.DisplayMember = "NamaSupplier";

            var mereks = merekService.Get();
            comboBoxMerek.DataSource = mereks;
            comboBoxMerek.DisplayMember = "NamaMerek";
            comboBoxMerek.ValueMember = "Id";
        }

        public void PopulateData()
        {
            int id = int.Parse(this.ParentForm.dataGridViewBarang.SelectedRows[0].Cells[0].Value.ToString());
            var barang = barangService.Get(id);

            textBoxId.Text = barang.Id.ToString();
            textBoxNamaBarang.Text = barang.NamaBarang;
            textBoxHargaJual.Text = barang.HargaJual.ToString();
            textBoxHargaBeli.Text = barang.HargaBeli.ToString();
            textBoxStok.Text = barang.Stok.ToString();
            textBoxKeterangan.Text = barang.Keterangan;
            textBoxKodeBarang.Text = barang.KodeBarang;
            comboBoxKategori.SelectedValue = barang.KategoriId;
            comboBoxSupplier.SelectedValue = barang.SupplierId;
            comboBoxMerek.SelectedValue = barang.MerekId;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            bool IsPass = true;
            if (string.IsNullOrEmpty(textBoxNamaBarang.Text))
            {
                IsPass = false;
                sb.Append("- Nama Barang harus diisi \n");
            }

            if (string.IsNullOrEmpty(textBoxHargaJual.Text))
            {
                IsPass = false;
                sb.Append("- Harga Jual harus diisi \n");
            }

            if (!string.IsNullOrEmpty(textBoxHargaJual.Text))
            {
                decimal result;
                bool IsHargaJualPass = decimal.TryParse(textBoxHargaJual.Text, out result);
                if (!IsHargaJualPass)
                {
                    IsPass = false;
                    sb.Append("- Harga Jual harus angka \n");
                }
            }

            if (string.IsNullOrEmpty(textBoxHargaBeli.Text))
            {
                IsPass = false;
                sb.Append("- Harga Beli harus diisi \n");
            }

            if (!string.IsNullOrEmpty(textBoxHargaBeli.Text))
            {
                decimal result;
                bool IsHargaBeliPass = decimal.TryParse(textBoxHargaBeli.Text, out result);
                if (!IsHargaBeliPass)
                {
                    IsPass = false;
                    sb.Append("- Harga Beli harus angka \n");
                }
            }

            if (string.IsNullOrEmpty(textBoxStok.Text))
            {
                IsPass = false;
                sb.Append("- Stok harus diisi \n");
            }

            if (!string.IsNullOrEmpty(textBoxStok.Text))
            {
                int result;
                bool IsStokPass = int.TryParse(textBoxStok.Text, out result);
                if (!IsStokPass)
                {
                    IsPass = false;
                    sb.Append("- Stok harus angka \n");
                }
            }

            if (string.IsNullOrEmpty(textBoxKeterangan.Text))
            {
                IsPass = false;
                sb.Append("- Keterangan harus diisi \n");
            }

            if (string.IsNullOrEmpty(textBoxKodeBarang.Text))
            {
                IsPass = false;
                sb.Append("- Kode Barang harus diisi \n");
            }

            if (comboBoxKategori.SelectedValue == null)
            {
                IsPass = false;
                sb.Append("- Kategori harus diisi \n");
            }

            if (comboBoxSupplier.SelectedValue == null)
            {
                IsPass = false;
                sb.Append("- Supplier harus diisi \n");
            }

            if (comboBoxMerek.SelectedValue == null)
            {
                IsPass = false;
                sb.Append("- Merek harus diisi \n");
            }

            if (!IsPass)
            {
                MessageBox.Show(sb.ToString(), "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var kategori = kategoriService.Get(int.Parse(comboBoxKategori.SelectedValue.ToString()));
            var supplier = supplierService.Get(int.Parse(comboBoxSupplier.SelectedValue.ToString()));
            var merek = merekService.Get(int.Parse(comboBoxMerek.SelectedValue.ToString()));
            var barang = barangService.Get(int.Parse(textBoxId.Text));
            
            barang.NamaBarang = textBoxNamaBarang.Text;
            barang.HargaJual = decimal.Parse(textBoxHargaJual.Text);
            barang.HargaBeli = decimal.Parse(textBoxHargaBeli.Text);
            barang.Stok = int.Parse(textBoxStok.Text);
            barang.Keterangan = textBoxKeterangan.Text;
            barang.KodeBarang = textBoxKodeBarang.Text;
            barang.KategoriId = kategori.Id;
            barang.SupplierId = supplier.Id;
            barang.MerekId = merek.Id;

            barangService.Put(barang);

            this.ParentForm.dataGridViewBarang.DataSource = barangService.Get();
            this.Dispose();
        }

        private void UbahBarang_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Rectangle rectNamaBarang = new Rectangle(panelNamaBarang.Location.X, panelNamaBarang.Location.Y,
                                                          panelNamaBarang.ClientSize.Width, panelNamaBarang.ClientSize.Height);

            System.Drawing.Rectangle rectHargaJual = new Rectangle(panelHargaJual.Location.X, panelHargaJual.Location.Y,
                                                          panelHargaJual.ClientSize.Width, panelHargaJual.ClientSize.Height);

            System.Drawing.Rectangle rectHargaBeli = new Rectangle(panelHargaBeli.Location.X, panelHargaBeli.Location.Y,
                                                          panelHargaBeli.ClientSize.Width, panelHargaBeli.ClientSize.Height);

            System.Drawing.Rectangle rectStok = new Rectangle(panelStok.Location.X, panelStok.Location.Y,
                                                          panelStok.ClientSize.Width, panelStok.ClientSize.Height);

            System.Drawing.Rectangle rectKeterangan = new Rectangle(panelKeterangan.Location.X, panelKeterangan.Location.Y,
                                                          panelKeterangan.ClientSize.Width, panelKeterangan.ClientSize.Height);

            System.Drawing.Rectangle rectKodeBarang = new Rectangle(panelKodeBarang.Location.X, panelKodeBarang.Location.Y,
                                                          panelKodeBarang.ClientSize.Width, panelKodeBarang.ClientSize.Height);

            System.Drawing.Rectangle rectKategori = new Rectangle(comboBoxKategori.Location.X, comboBoxKategori.Location.Y,
                                                          comboBoxKategori.ClientSize.Width, comboBoxKategori.ClientSize.Height);

            System.Drawing.Rectangle rectSupplier = new Rectangle(comboBoxSupplier.Location.X, comboBoxSupplier.Location.Y,
                                                        comboBoxSupplier.ClientSize.Width, comboBoxSupplier.ClientSize.Height);

            System.Drawing.Rectangle rectMerek = new Rectangle(comboBoxMerek.Location.X, comboBoxMerek.Location.Y,
                                                         comboBoxMerek.ClientSize.Width, comboBoxMerek.ClientSize.Height);

            rectNamaBarang.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectNamaBarang, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);

            rectHargaJual.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectHargaJual, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);

            rectHargaBeli.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectHargaBeli, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);

            rectStok.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectStok, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);

            rectKeterangan.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectKeterangan, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);

            rectKategori.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectKategori, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);

            rectSupplier.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectSupplier, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);

            rectMerek.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectMerek, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);

            rectKodeBarang.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectKodeBarang, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);
        }

        private void textBoxKodeBarang_Leave(object sender, EventArgs e)
        {
            var barang = barangService.Get(int.Parse(textBoxId.Text));
            if(!textBoxKodeBarang.Text.Equals(barang.KodeBarang))
            {
                var barangKodeFound = barangService.FindByKodeBarang(textBoxKodeBarang.Text);
                if (barangKodeFound != null)
                {
                    MessageBox.Show("Kode Barang sudah dipakai");
                    this.ActiveControl = this.textBoxKodeBarang;
                }
            }
        }
    }
}
