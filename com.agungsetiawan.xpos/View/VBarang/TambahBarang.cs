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
    public partial class TambahBarang : Form
    {
        public ListBarang ParentForm { get; set; }

        KategoriService kategoriService;
        BarangService barangService;
        SupplierService supplierService;
        MerekService merekService;

        public TambahBarang()
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
            comboBoxKategori.SelectedValue = -1;

            var suppliers = supplierService.Get();
            comboBoxSupplier.DataSource = suppliers;
            comboBoxSupplier.ValueMember = "Id";
            comboBoxSupplier.DisplayMember = "NamaSupplier";
            comboBoxSupplier.SelectedValue = -1;

            var mereks = merekService.Get();
            comboBoxMerek.DataSource = mereks;
            comboBoxMerek.DisplayMember = "NamaMerek";
            comboBoxMerek.ValueMember = "Id";
            comboBoxMerek.SelectedValue = -1;

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            bool IsPass = true;
            if(string.IsNullOrEmpty(textBoxNamaBarang.Text))
            {
                IsPass = false;
                sb.Append("- Nama Barang harus diisi \n");
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

            if(dataGridViewSHU.Rows.Count <= 1)
            {
                IsPass = false;
                sb.Append("- Minimal harus ada 1 ukuran \n");
            }

            if(!IsPass)
            {
                MessageBox.Show(sb.ToString(),"Invalid Input",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            var kategori = kategoriService.Get(int.Parse(comboBoxKategori.SelectedValue.ToString()));
            var supplier = supplierService.Get(int.Parse(comboBoxSupplier.SelectedValue.ToString()));
            var merek = merekService.Get(int.Parse(comboBoxMerek.SelectedValue.ToString()));

            var barang = new Barang()
            {
                NamaBarang=textBoxNamaBarang.Text,
                Keterangan=textBoxKeterangan.Text,
                KodeBarang=textBoxKodeBarang.Text,
                KategoriId=kategori.Id,
                SupplierId=supplier.Id,
                MerekId=merek.Id
            };

            StokHargaUkuran stokHargaUkuran;
            for (int i = 0; i < dataGridViewSHU.Rows.Count-1 ;i++ )
            {
                stokHargaUkuran=new StokHargaUkuran();
                stokHargaUkuran.Ukuran=dataGridViewSHU.Rows[i].Cells[0].Value.ToString();
                stokHargaUkuran.HargaBeli=decimal.Parse(dataGridViewSHU.Rows[i].Cells[1].Value.ToString());
                stokHargaUkuran.HargaJual=decimal.Parse(dataGridViewSHU.Rows[i].Cells[2].Value.ToString());
                stokHargaUkuran.Stock=int.Parse(dataGridViewSHU.Rows[i].Cells[3].Value.ToString());

                barang.StockHargaUkurans.Add(stokHargaUkuran);
            }

            barangService.Post(barang);

            this.ParentForm.dataGridViewBarang.DataSource = barangService.Get();
            this.Dispose();
        }

        private void TambahBarang_Paint(object sender, PaintEventArgs e)
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

            System.Drawing.Rectangle rectUkuran = new Rectangle(panelUkuran.Location.X, panelUkuran.Location.Y,
                                                        panelUkuran.ClientSize.Width, panelUkuran.ClientSize.Height);

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

            rectUkuran.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectUkuran, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);

        }

        private void textBoxKodeBarang_Leave(object sender, EventArgs e)
        {
            var barang = barangService.FindByKodeBarang(textBoxKodeBarang.Text);
            if(barang!=null)
            {
                MessageBox.Show("Kode Barang sudah dipakai");
                this.ActiveControl = this.textBoxKodeBarang;
            }
        }

        private void BtnGenerateKodeBarang_Click(object sender, EventArgs e)
        {
            string namaBarang = textBoxNamaBarang.Text;
            string merek = comboBoxMerek.Text;

            if (string.IsNullOrEmpty(namaBarang) || string.IsNullOrEmpty(merek))
                return;

            string kodeBarang = barangService.GenerateKodeBarang(namaBarang, merek);
            textBoxKodeBarang.Text = kodeBarang;
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            bool IsPass = true;

            if (string.IsNullOrEmpty(textBoxUkuran.Text))
            {
                IsPass = false;
                sb.Append("- Ukuran harus diisi \n");
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

            if (!IsPass)
            {
                MessageBox.Show(sb.ToString(), "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridViewSHU.Rows.Add(textBoxUkuran.Text, textBoxHargaBeli.Text, textBoxHargaJual.Text, textBoxStok.Text);
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dataGridViewSHU.Rows.Count <= 1 || dataGridViewSHU.Rows.Count - 1 == dataGridViewSHU.CurrentCell.RowIndex)
                return;

            int currentRowIndex = dataGridViewSHU.CurrentCell.RowIndex;
            dataGridViewSHU.Rows.RemoveAt(currentRowIndex);
        }

    }
}
