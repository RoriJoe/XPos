using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using com.agungsetiawan.xpos.Model;

namespace com.agungsetiawan.xpos.View.VBarang
{
    public partial class ListBarang : Form
    {
        public ListBarang()
        {
            InitializeComponent();

            var Barangs = new List<Barang>()
            {
                new Barang(){Id=1,NamaBarang="Xmen",Stok=10,Keterangan="apik",Kategori=null,HargaBeli=45000,HargaJual=50000},
                new Barang(){Id=2,NamaBarang="Lmen",Stok=11,Keterangan="apik",Kategori=null,HargaBeli=45000,HargaJual=50000},
                new Barang(){Id=3,NamaBarang="Superman",Stok=4,Keterangan="apik",Kategori=null,HargaBeli=45000,HargaJual=50000},
                new Barang(){Id=4,NamaBarang="Batman",Stok=9,Keterangan="apik",Kategori=null,HargaBeli=45000,HargaJual=50000},
                new Barang(){Id=5,NamaBarang="Spiderman",Stok=12,Keterangan="apik",Kategori=null,HargaBeli=45000,HargaJual=50000}
            };

            dataGridViewBarang.DataSource = Barangs;
            dataGridViewBarang.Columns[0].Visible = false;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            TambahBarang form = new TambahBarang();
            form.ShowDialog();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            UbahBarang form = new UbahBarang();
            form.ShowDialog();
        }

        private void dataGridViewBarang_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            byte x=0;
            DataGridView dgv = sender as DataGridView;
            String index = (e.RowIndex + 1).ToString();
            System.Drawing.Font font = new Font("Tahoma", 8.0f, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, x);

            StringFormat centerFormat = new StringFormat();
            centerFormat.Alignment = StringAlignment.Center;
            centerFormat.LineAlignment = StringAlignment.Center;

            Rectangle headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top,
                dgv.RowHeadersWidth, e.RowBounds.Height);

            e.Graphics.DrawString(index, font, SystemBrushes.ControlText,
                headerBounds, centerFormat);
        }
    }
}
