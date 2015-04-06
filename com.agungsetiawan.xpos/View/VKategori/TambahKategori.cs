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
    public partial class TambahKategori : Form
    {
        KategoriService kategoriService;
        public ListKategori ParentForm { get; set; }
        public TambahKategori()
        {
            InitializeComponent();
            this.ActiveControl = this.textBoxNamaKategori;
            kategoriService = new KategoriService();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            bool IsPass = true;

            if(string.IsNullOrEmpty(textBoxNamaKategori.Text))
            {
                sb.Append("- Nama Kategori harus diisi \n");
                IsPass = false;
            }

            if (string.IsNullOrEmpty(textBoxKeterangan.Text))
            {
                sb.Append("- Keterangan harus diisi \n");
                IsPass = false;
            }

            if(!IsPass)
            {
                MessageBox.Show(sb.ToString(), "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var kategori = new Kategori()
            {
                NamaKategori=textBoxNamaKategori.Text,
                Keterangan=textBoxKeterangan.Text
            };

            kategoriService.Post(kategori);

            this.ParentForm.dataGridViewKategori.DataSource = kategoriService.Get();
            this.Dispose();
        }

        private void TambahKategori_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Rectangle rectNamaKategori = new Rectangle(panelNamaKategori.Location.X, panelNamaKategori.Location.Y,
                                                         panelNamaKategori.ClientSize.Width, panelNamaKategori.ClientSize.Height);

            System.Drawing.Rectangle rectKeterangan = new Rectangle(panelKeterangan.Location.X, panelKeterangan.Location.Y,
                                                          panelKeterangan.ClientSize.Width, panelKeterangan.ClientSize.Height);

            rectNamaKategori.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectNamaKategori, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);

            rectKeterangan.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectKeterangan, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);
        }
    }
}
