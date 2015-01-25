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
using com.agungsetiawan.xpos.Repository;

namespace com.agungsetiawan.xpos.View.VBarang
{
    public partial class ListBarang : Form
    {
        BarangRepository barangRepository;
        public ListBarang()
        {
            InitializeComponent();
            barangRepository = new BarangRepository();

            var Barangs = barangRepository.Get().Skip(0).Take(10).ToList();

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
