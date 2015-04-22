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
    public partial class UbahRole : Form
    {
        public ListRole ParentForm { get; set; }
        private RoleService roleService;
        public UbahRole()
        {
            InitializeComponent();
            this.ActiveControl = this.textBoxNamaRole;
            roleService = new RoleService();
        }

        public void PopulateData()
        {
            int id = int.Parse(this.ParentForm.dataGridViewRole.SelectedRows[0].Cells[0].Value.ToString());
            var role = roleService.Get(id);

            labelHiddenId.Text = role.Id.ToString();
            textBoxNamaRole.Text = role.NamaRole;
            textBoxKeterangan.Text = role.Keterangan;

            var permissions = role.Permissions;

            if (permissions.Contains("barang"))
            {
                checkBoxBarang.Checked = true;
            }

            if (permissions.Contains("kategori"))
            {
                checkBoxKategori.Checked = true;
            }

            if (permissions.Contains("role"))
            {
                checkBoxRole.Checked = true;
            }

            if (permissions.Contains("pengguna"))
            {
                checkBoxPengguna.Checked = true;
            }

            if (permissions.Contains("member"))
            {
                checkBoxMember.Checked = true;
            }

            if (permissions.Contains("pelanggan"))
            {
                checkBoxPelanggan.Checked = true;
            }

            if (permissions.Contains("supplier"))
            {
                checkBoxSupplier.Checked = true;
            }

            if (permissions.Contains("kasir penjualan"))
            {
                checkBoxPenjualan.Checked = true;
            }

            if (permissions.Contains("daftar penjualan"))
            {
                checkBoxDaftarPenjualan.Checked = true;
            }

            if (permissions.Contains("kasir pembelian"))
            {
                checkBoxPembelian.Checked = true;
            }

            if (permissions.Contains("daftar pembelian"))
            {
                checkBoxDaftarPembelian.Checked = true;
            }

            if (permissions.Contains("laporan"))
            {
                checkBoxLaporan.Checked = true;
            }

            if (permissions.Contains("merek"))
            {
                checkBoxMerek.Checked = true;
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            StringBuilder sbPermissions = new StringBuilder();
            StringBuilder sb = new StringBuilder();
            bool IsPass = true;
            if (string.IsNullOrEmpty(textBoxNamaRole.Text))
            {
                IsPass = false;
                sb.Append("- Nama Role harus diisi \n");
            }

            if (string.IsNullOrEmpty(textBoxKeterangan.Text))
            {
                IsPass = false;
                sb.Append("- Keterangan harus diisi \n");
            }

            if (checkBoxBarang.Checked)
            {
                sbPermissions.Append("barang,");
            }

            if (checkBoxDaftarPembelian.Checked)
            {
                sbPermissions.Append("daftar pembelian,");
            }

            if (checkBoxDaftarPenjualan.Checked)
            {
                sbPermissions.Append("daftar penjualan,");
            }

            if (checkBoxKategori.Checked)
            {
                sbPermissions.Append("kategori,");
            }

            if (checkBoxLaporan.Checked)
            {
                sbPermissions.Append("laporan,");
            }

            if (checkBoxMember.Checked)
            {
                sbPermissions.Append("member,");
            }

            if (checkBoxPelanggan.Checked)
            {
                sbPermissions.Append("pelanggan,");
            }

            if (checkBoxPembelian.Checked)
            {
                sbPermissions.Append("kasir pembelian,");
            }

            if (checkBoxPengguna.Checked)
            {
                sbPermissions.Append("pengguna,");
            }

            if (checkBoxPenjualan.Checked)
            {
                sbPermissions.Append("kasir penjualan,");
            }

            if (checkBoxRole.Checked)
            {
                sbPermissions.Append("role,");
            }

            if (checkBoxSupplier.Checked)
            {
                sbPermissions.Append("supplier,");
            }

            if (checkBoxMerek.Checked)
            {
                sbPermissions.Append("merek,");
            }

            if (string.IsNullOrEmpty(sbPermissions.ToString()))
            {
                IsPass = false;
                sb.Append("- Role harus diisi minimal 1 \n");
            }

            if (!IsPass)
            {
                MessageBox.Show(sb.ToString(), "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var role = roleService.Get(int.Parse(labelHiddenId.Text));
            role.NamaRole = textBoxNamaRole.Text;
            role.Keterangan = textBoxKeterangan.Text;
            role.Permissions = sbPermissions.ToString();

            roleService.Put(role);

            this.ParentForm.dataGridViewRole.DataSource = roleService.Get();
            this.Dispose();
        }

        private void UbahRole_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Rectangle rectNamaSupplier = new Rectangle(panelNamaRole.Location.X, panelNamaRole.Location.Y,
                                                          panelNamaRole.ClientSize.Width, panelNamaRole.ClientSize.Height);

            System.Drawing.Rectangle rectKeterangan = new Rectangle(panelKeterangan.Location.X, panelKeterangan.Location.Y,
                                                          panelKeterangan.ClientSize.Width, panelKeterangan.ClientSize.Height);

            rectNamaSupplier.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectNamaSupplier, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);

            rectKeterangan.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectKeterangan, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);

        }
    }
}
