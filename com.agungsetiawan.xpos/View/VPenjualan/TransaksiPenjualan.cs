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

namespace com.agungsetiawan.xpos.View.VPenjualan
{
    public partial class TransaksiPenjualan : Form
    {
        public TransaksiPenjualan()
        {
            InitializeComponent();
            dataGridView1.Rows.Add("", "", "", "");
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {

            BarangService service = new BarangService();

            if(e.KeyCode==Keys.Enter)
            {
                int row = dataGridView1.Rows.Count;
                int id = int.Parse(dataGridView1[0, row-2].Value.ToString());
                var barang = service.Get(id);

                dataGridView1.Rows[row - 2].Cells[0].Value = barang.Id;
                dataGridView1.Rows[row - 2].Cells[1].Value = barang.NamaBarang;
                dataGridView1.Rows[row - 2].Cells[2].Value = 1;
                dataGridView1.Rows[row - 2].Cells[3].Value =barang.HargaJual;

                dataGridView1.Refresh();

            }

            if(e.KeyCode==Keys.F12)
            {
                int row = dataGridView1.Rows.Count;
                int n = int.Parse(dataGridView1.Rows[row - 2].Cells[2].Value.ToString());
                dataGridView1.Rows[row - 2].Cells[2].Value = n+1;
                dataGridView1.Refresh();
            }

            if (e.KeyCode == Keys.F11)
            {
                int row = dataGridView1.Rows.Count;
                int n = int.Parse(dataGridView1.Rows[row - 2].Cells[2].Value.ToString());
                dataGridView1.Rows[row - 2].Cells[2].Value = n - 1;
                dataGridView1.Refresh();
            }
        }
    }
}
