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
using System.Windows.Forms.DataVisualization.Charting;

namespace com.agungsetiawan.xpos.View.VLaporan
{
    public partial class LaporanPenjualan : Form
    {
        private static LaporanPenjualan form;
        private KategoriService kategoriService;
        private BarangService barangService;
        private LaporanService laporanService;
        private LaporanPenjualan()
        {
            InitializeComponent();
            kategoriService = new KategoriService();
            barangService = new BarangService();
            laporanService = new LaporanService();

            comboBoxJenis.Items.Add("Kategori");
            comboBoxJenis.Items.Add("Barang");
            comboBoxJenis.SelectedItem = "Kategori";

            comboBoxKatOrBarang.DataSource = kategoriService.Get();
            comboBoxKatOrBarang.DisplayMember = "NamaKategori";
            comboBoxKatOrBarang.ValueMember = "Id";

            chartPenjualan.ChartAreas[0].AxisY.Interval = 1;
            chartPenjualan.ChartAreas[0].AxisX.Interval = 1;
            List<Laporan> data = laporanService.GetLaporan();

            Series series = new Series("Jumlah Transaksi Penjualan");

            foreach (var d in data)
            {
                series.Points.AddXY(d.Tanggal, d.Jumlah);
            }

            //series.Points.AddXY(1, 2);
            //series.Points.AddXY(2, 3);
            //series.Points.AddXY(3, 4);

            chartPenjualan.Series.Add(series);
        }

        public static LaporanPenjualan GetForm()
        {
            if(form==null || form.IsDisposed)
            {
                form = new LaporanPenjualan();
            }

            return form;
        }

        private void comboBoxJenis_SelectedValueChanged(object sender, EventArgs e)
        {
            var value = comboBoxJenis.SelectedItem.ToString();

            if(value.Equals("Barang"))
            {
                labelKatOrBarang.Text = "Barang";
                comboBoxKatOrBarang.DataSource = barangService.Get();
                comboBoxKatOrBarang.DisplayMember = "NamaBarang";
                comboBoxKatOrBarang.ValueMember = "Id";
            } else if(value.Equals("Kategori"))
            {
                labelKatOrBarang.Text = "Kategori";
                comboBoxKatOrBarang.DataSource = kategoriService.Get();
                comboBoxKatOrBarang.DisplayMember = "NamaKategori";
                comboBoxKatOrBarang.ValueMember = "Id";
            }
        }
    }
}
