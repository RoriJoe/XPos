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

namespace com.agungsetiawan.xpos.View.VRole
{
    public partial class ListRole : Form
    {
        private static ListRole form;
        private RoleService roleService;
        private ListRole()
        {
            InitializeComponent();

            roleService = new RoleService();
            dataGridViewRole.DataSource = roleService.Get();
            dataGridViewRole.Columns[0].Visible = false;
        }

        public static ListRole GetForm()
        {
            if (form == null || form.IsDisposed)
                form = new ListRole();

            return form;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            TambahRole form = new TambahRole();
            form.ParentForm = this;
            form.ShowDialog();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            UbahRole form = new UbahRole();
            form.ParentForm = this;
            form.PopulateData();
            form.ShowDialog();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridViewRole.SelectedRows[0].Cells[0].Value.ToString());
            var role = roleService.Get(id);

            DialogResult result = MessageBox.Show("Hapus data " + role.NamaRole + " ?", "Hapus", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                roleService.Delete(role);
                dataGridViewRole.DataSource = roleService.Get();
            }
        }
    }
}
