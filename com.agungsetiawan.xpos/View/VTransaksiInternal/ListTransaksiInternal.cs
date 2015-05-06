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
    public partial class ListTransaksiInternal : Form
    {
        private TransaksiInternalService transaksiInternalService;
        private static ListTransaksiInternal form;
        private ListTransaksiInternal()
        {
            InitializeComponent();
            transaksiInternalService = new TransaksiInternalService();

            dataGridViewTransaksiInternal.DataSource = transaksiInternalService.Get();
            dataGridViewTransaksiInternal.Columns[0].Visible = false;
        }

        public static ListTransaksiInternal GetForm()
        {
            if(form==null || form.IsDisposed)
            {
                form = new ListTransaksiInternal();
            }

            return form;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            TambahTransaksiInternal form = new TambahTransaksiInternal();
            form.ParentForm = this;
            form.ShowDialog();
        }
    }
}
