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

        public UbahBarang()
        {
            InitializeComponent();
            kategoriService = new KategoriService();
            barangService = new BarangService();

            var kategoris = kategoriService.Get();
            comboBoxKategori.DataSource = kategoris;
            comboBoxKategori.ValueMember = "Id";
            comboBoxKategori.DisplayMember = "NamaKategori";
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
            comboBoxKategori.SelectedValue = barang.KategoriId;
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

            if (comboBoxKategori.SelectedValue == null)
            {
                IsPass = false;
                sb.Append("- Kategori harus diisi \n");
            }

            if (!IsPass)
            {
                MessageBox.Show(sb.ToString(), "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var kategori = kategoriService.Get(int.Parse(comboBoxKategori.SelectedValue.ToString()));

            var barang = barangService.Get(int.Parse(textBoxId.Text));
            
            barang.NamaBarang = textBoxNamaBarang.Text;
            barang.HargaJual = decimal.Parse(textBoxHargaJual.Text);
            barang.HargaBeli = decimal.Parse(textBoxHargaBeli.Text);
            barang.Stok = int.Parse(textBoxStok.Text);
            barang.Keterangan = textBoxKeterangan.Text;
            barang.KategoriId = kategori.Id;
            

            barangService.Put(barang);

            this.ParentForm.dataGridViewBarang.DataSource = barangService.Get();
            this.Dispose();
        }
    }
}
