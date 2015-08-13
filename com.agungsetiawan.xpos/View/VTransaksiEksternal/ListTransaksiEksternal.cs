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

namespace com.agungsetiawan.xpos.View.VTransaksiInternal
{
    public partial class ListTransaksiEksternal : Form
    {
        private TransaksiEksternalService transaksiEksternalService;
        private static ListTransaksiEksternal form;
        private ListTransaksiEksternal()
        {
            InitializeComponent();
            transaksiEksternalService = new TransaksiEksternalService();

            dataGridViewTransaksiEksternal.DataSource = transaksiEksternalService.Get();
            dataGridViewTransaksiEksternal.Columns[0].Visible = false;
        }

        public static ListTransaksiEksternal GetForm()
        {
            if(form==null || form.IsDisposed)
            {
                form = new ListTransaksiEksternal();
            }

            return form;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            TambahTransaksiEksternal form = new TambahTransaksiEksternal();
            form.ParentForm = this;
            form.ShowDialog();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            UbahTransaksiEksternal form = new UbahTransaksiEksternal();
            form.ParentForm = this;
            form.PopulateData();
            form.ShowDialog();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridViewTransaksiEksternal.SelectedRows[0].Cells[0].Value.ToString());
            var transaksiInternal = transaksiEksternalService.Get(id);

            DialogResult result = MessageBox.Show("Hapus data " + transaksiInternal.Keterangan + " ?", "Hapus", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                transaksiEksternalService.Delete(transaksiInternal);
                dataGridViewTransaksiEksternal.DataSource = transaksiEksternalService.Get();
            }
        }
    }
}
