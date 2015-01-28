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

namespace com.agungsetiawan.xpos.View.VKategori
{
    public partial class UbahKategori : Form
    {
        public ListKategori ParentForm { get; set; }
        KategoriService kategoriService;
        public UbahKategori()
        {
            InitializeComponent();
            kategoriService = new KategoriService();
        }

        public void PopulateData()
        {
            int id = int.Parse(this.ParentForm.dataGridViewKategori.SelectedRows[0].Cells[0].Value.ToString());
            var kategori = kategoriService.Get(id);

            textBoxId.Text = id.ToString();
            textBoxNamaKategori.Text = kategori.NamaKategori;
            textBoxKeterangan.Text = kategori.Keterangan;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            var kategori = kategoriService.Get(int.Parse(textBoxId.Text));

            kategori.NamaKategori = textBoxNamaKategori.Text;
            kategori.Keterangan = textBoxKeterangan.Text;

            kategoriService.Put(kategori);

            this.ParentForm.dataGridViewKategori.DataSource = kategoriService.Get();
            this.Dispose();
        }
    }
}
