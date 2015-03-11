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
    public partial class ListPenjualan : Form
    {
        static ListPenjualan form;
        PenjualanService penjualanService;
        PenjualanDetailService penjualanDetailService;
        private ListPenjualan()
        {
            InitializeComponent();

            penjualanService = new PenjualanService();
            penjualanDetailService = new PenjualanDetailService();

            dataGridViewDaftarPenjualan.DataSource = penjualanService.FindWithPelangganDanPengguna();
            dataGridViewDaftarPenjualan.Columns[0].Visible = false;
        }

        public static ListPenjualan GetForm()
        {
            if (form == null || form.IsDisposed)
                form = new ListPenjualan();

            return form;
        }

        private void dataGridViewDaftarPenjualan_SelectionChanged(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridViewDaftarPenjualan.SelectedRows[0].Cells[0].Value.ToString());
            dataGridViewDaftarPenjualanDetail.DataSource = penjualanDetailService.FindByPenjualanId(id);
            dataGridViewDaftarPenjualanDetail.Columns[0].Visible = false;
        }
    }
}
