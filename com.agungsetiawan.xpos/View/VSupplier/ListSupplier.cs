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

namespace com.agungsetiawan.xpos.View.VSupplier
{
    public partial class ListSupplier : Form
    {
        static ListSupplier form;
        private SupplierService supplierService;
        private ListSupplier()
        {
            InitializeComponent();
            supplierService = new SupplierService();
            dataGridViewSupplier.DataSource = supplierService.Get();
            dataGridViewSupplier.Columns[0].Visible = false;
        }

        public static ListSupplier GetForm()
        {
            if(form==null || form.IsDisposed)
            {
                form = new ListSupplier();
            }

            return form;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            TambahSupplier form = new TambahSupplier();
            form.ParentForm = this;
            form.ShowDialog();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            UbahSupplier form = new UbahSupplier();
            form.ParentForm = this;
            form.PopulateData();
            form.ShowDialog();
        }
    }
}
