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

namespace com.agungsetiawan.xpos.View.VKategori
{
    public partial class ListKategori : Form
    {
        static ListKategori form;
        KategoriService kategoriService;
        private ListKategori()
        {
            InitializeComponent();

            kategoriService = new KategoriService();

            var Kategoris = kategoriService.Get();
            dataGridViewKategori.DataSource = Kategoris;
        }

        public static ListKategori GetForm()
        {
            if(form==null || form.IsDisposed)
            {
                form = new ListKategori();
            }

            return form;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            TambahKategori form = new TambahKategori();
            form.ParentForm = this;
            form.ShowDialog();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            UbahKategori form = new UbahKategori();
            form.ParentForm = this;
            form.PopulateData();
            form.ShowDialog();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridViewKategori.SelectedRows[0].Cells[0].Value.ToString());
            var kategori = kategoriService.Get(id);

            DialogResult result = MessageBox.Show("Hapus data " + kategori.NamaKategori + " ?", "Hapus", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                kategoriService.Delete(kategori);
                dataGridViewKategori.DataSource = kategoriService.Get();
            }
        }
    }
}
