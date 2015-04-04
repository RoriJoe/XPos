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

        private void btnHapus_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridViewSupplier.SelectedRows[0].Cells[0].Value.ToString());
            var supplier = supplierService.Get(id);

            DialogResult result = MessageBox.Show("Hapus data " + supplier.NamaSupplier + " ?", "Hapus", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                supplierService.Delete(supplier);
                dataGridViewSupplier.DataSource = supplierService.Get();
            }
        }

        private void dataGridViewSupplier_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            byte x = 0;
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
