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

namespace com.agungsetiawan.xpos.View.VPelanggan
{
    public partial class ListPelanggan : Form
    {
        PelangganService pelangganService;
        static ListPelanggan form;
        private ListPelanggan()
        {
            InitializeComponent();
            pelangganService = new PelangganService();

            dataGridViewPelanggan.DataSource = pelangganService.Get();
            dataGridViewPelanggan.Columns[0].Visible = false;
        }

        public static ListPelanggan GetForm()
        {
            if (form == null || form.IsDisposed)
                form = new ListPelanggan();

            return form;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            TambahPelanggan form = new TambahPelanggan();
            form.ParentForm = this;
            form.ShowDialog();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            UbahPelanggan form = new UbahPelanggan();
            form.ParentForm = this;
            form.PopulateData();
            form.ShowDialog();
        }
    }
}
