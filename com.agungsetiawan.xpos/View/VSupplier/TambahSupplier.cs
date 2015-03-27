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

namespace com.agungsetiawan.xpos.View.VSupplier
{
    public partial class TambahSupplier : Form
    {
        public ListSupplier ParentForm { get; set; }
        private SupplierService supplierService;
        public TambahSupplier()
        {
            InitializeComponent();
            supplierService = new SupplierService();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            bool IsPass = true;
            if (string.IsNullOrEmpty(textBoxNamaSupplier.Text))
            {
                IsPass = false;
                sb.Append("- Nama Supplier harus diisi \n");
            }

            if (string.IsNullOrEmpty(textBoxAlamat.Text))
            {
                IsPass = false;
                sb.Append("- Alamat harus diisi \n");
            }

            if (string.IsNullOrEmpty(textBoxNomorTelepon.Text))
            {
                IsPass = false;
                sb.Append("- Nomor Telepon harus diisi \n");
            }

            if(!IsPass)
            {
                MessageBox.Show(sb.ToString(),"Invalid Input",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            var supplier = new Supplier()
            {
                NamaSupplier=textBoxNamaSupplier.Text,
                Alamat=textBoxAlamat.Text,
                NoTelepon=textBoxNomorTelepon.Text
            };

            supplierService.Post(supplier);

            this.ParentForm.dataGridViewSupplier.DataSource = supplierService.Get();
            this.Dispose();
        }
    }
}
