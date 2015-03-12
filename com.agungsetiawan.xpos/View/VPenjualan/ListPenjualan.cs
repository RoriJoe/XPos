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

            comboBoxCari.Items.Add("Kode Transaksi");
            comboBoxCari.Items.Add("Pelanggan");
            comboBoxCari.Items.Add("Tanggal");

            comboBoxCari.SelectedItem = "Kode Transaksi";

            dateTimePickerCari.Format = DateTimePickerFormat.Custom;
            dateTimePickerCari.CustomFormat = "dd MMMM yyyy";
        }

        public static ListPenjualan GetForm()
        {
            if (form == null || form.IsDisposed)
                form = new ListPenjualan();

            return form;
        }

        private void dataGridViewDaftarPenjualan_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewDaftarPenjualan.Rows.Count < 1)
                return;

            int id=0;
            bool isValid;
            try
            {
                isValid = int.TryParse(dataGridViewDaftarPenjualan.SelectedRows[0].Cells[0].Value.ToString(), out id);
            }
            catch(ArgumentOutOfRangeException exception)
            {
                isValid = false;
            }
            

            if (!isValid || id==0)
                return;

            dataGridViewDaftarPenjualanDetail.DataSource = penjualanDetailService.FindByPenjualanId(id);
            dataGridViewDaftarPenjualanDetail.Columns[0].Visible = false;
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            var value = comboBoxCari.SelectedItem.ToString();
            if(value.Equals("Kode Transaksi"))
            {
                var result=penjualanService.FindByKodeTransaksi(textBoxCari.Text);

                dataGridViewDaftarPenjualan.DataSource = result;
            } 
            else if (value.Equals("Pelanggan"))
            {
                var result = penjualanService.FindByPelanggan(textBoxCari.Text);

                dataGridViewDaftarPenjualan.DataSource = result;
            }
            else if(value.Equals("Tanggal"))
            {
                var date = dateTimePickerCari.Value;
                dataGridViewDaftarPenjualan.DataSource = penjualanService.FindByTanggal(date);
            }
        }

        private void comboBoxCari_SelectedValueChanged(object sender, EventArgs e)
        {
            var value = comboBoxCari.SelectedItem.ToString();

            if (value.Equals("Tanggal"))
            {
                textBoxCari.Visible = false;
                dateTimePickerCari.Visible = true;

                dateTimePickerCari.Location = new Point(textBoxCari.Location.X, textBoxCari.Location.Y);
            }

            if ((value.Equals("Kode Transaksi") || value.Equals("Pelanggan")) && dateTimePickerCari.Visible)
            {
                textBoxCari.Visible = true;
                dateTimePickerCari.Visible = false;

                textBoxCari.Location = new Point(dateTimePickerCari.Location.X, dateTimePickerCari.Location.Y);
            }
        }
    }
}
