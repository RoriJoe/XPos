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

namespace com.agungsetiawan.xpos.View.VPengguna
{
    public partial class UbahPengguna : Form
    {
        public ListPengguna ParentForm { get; set; }
        private PenggunaService penggunaService;
        private RoleService roleService;
        public UbahPengguna()
        {
            InitializeComponent();
            this.ActiveControl = this.textBoxNamaPengguna;
            penggunaService = new PenggunaService();
            roleService = new RoleService();

            comboBoxRole.DataSource = roleService.Get();
            comboBoxRole.ValueMember = "Id";
            comboBoxRole.DisplayMember = "NamaRole";
        }

        public void PopulateData()
        {
            int id = int.Parse(this.ParentForm.dataGridViewPengguna.SelectedRows[0].Cells[0].Value.ToString());
            var pengguna = penggunaService.Get(id);

            labelIdHidden.Text = pengguna.Id.ToString();
            textBoxNamaPengguna.Text = pengguna.Nama;
            textBoxUsername.Text = pengguna.Username;
            comboBoxRole.SelectedValue = pengguna.RoleId;
        }

        private void UbahPengguna_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Rectangle rectNamaPengguna = new Rectangle(panelNamaPengguna.Location.X, panelNamaPengguna.Location.Y,
                                                          panelNamaPengguna.ClientSize.Width, panelNamaPengguna.ClientSize.Height);

            System.Drawing.Rectangle rectUsername = new Rectangle(panelUsername.Location.X, panelUsername.Location.Y,
                                                          panelUsername.ClientSize.Width, panelUsername.ClientSize.Height);

            System.Drawing.Rectangle rectPassword = new Rectangle(panelPassword.Location.X, panelPassword.Location.Y,
                                                          panelPassword.ClientSize.Width, panelPassword.ClientSize.Height);

            System.Drawing.Rectangle rectRole = new Rectangle(comboBoxRole.Location.X, comboBoxRole.Location.Y,
                                                          comboBoxRole.ClientSize.Width, comboBoxRole.ClientSize.Height);

            rectNamaPengguna.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectNamaPengguna, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);

            rectUsername.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectUsername, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);

            rectPassword.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectPassword, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);

            rectRole.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectRole, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            bool IsPass = true;
            if (string.IsNullOrEmpty(textBoxNamaPengguna.Text))
            {
                IsPass = false;
                sb.Append("- Nama Pengguna harus diisi \n");
            }

            if (string.IsNullOrEmpty(textBoxUsername.Text))
            {
                IsPass = false;
                sb.Append("- Username harus diisi \n");
            }

            if (comboBoxRole.SelectedValue == null)
            {
                IsPass = false;
                sb.Append("- Role harus diisi \n");
            }

            if (!IsPass)
            {
                MessageBox.Show(sb.ToString(), "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var role = roleService.Get(int.Parse(comboBoxRole.SelectedValue.ToString()));
            var pengguna = penggunaService.Get(int.Parse(labelIdHidden.Text));

            pengguna.Nama = textBoxNamaPengguna.Text;
            pengguna.Username = textBoxUsername.Text;

            if(!string.IsNullOrEmpty(textBoxPassword.Text))
                pengguna.Password = textBoxPassword.Text;
            
            pengguna.RoleId = role.Id;
          
            penggunaService.Put(pengguna);

            this.ParentForm.dataGridViewPengguna.DataSource = penggunaService.FindWithRole();
            this.Dispose(); 
        }
    }
}
