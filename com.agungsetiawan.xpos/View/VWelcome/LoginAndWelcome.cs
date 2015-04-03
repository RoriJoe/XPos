using com.agungsetiawan.xpos.Common;
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

namespace com.agungsetiawan.xpos.View.VWelcome
{
    public partial class LoginAndWelcome : Form
    {
        public MainForm ParentForm { get; set; }
        private PenggunaService penggunaService;
        public LoginAndWelcome()
        {
            InitializeComponent();
            penggunaService = new PenggunaService();
            this.ActiveControl = this.textBoxUsername;
        }

        private void LoginAndWelcome_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Rectangle rectUsername = new Rectangle(panelUsername.Location.X, panelUsername.Location.Y,
                                                          panelUsername.ClientSize.Width, panelUsername.ClientSize.Height);

            System.Drawing.Rectangle rectPassword = new Rectangle(panelPassword.Location.X, panelPassword.Location.Y,
                                                         panelPassword.ClientSize.Width, panelPassword.ClientSize.Height);

            rectUsername.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectUsername, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);

            rectPassword.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectPassword, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            var penggunaLogin = penggunaService.FindByUsernamePassword(textBoxUsername.Text, textBoxPassword.Text);
            if(penggunaLogin==null)
            {
                labelWarning.Visible = true;
                return;
            }

            LoginContext.Pengguna = penggunaLogin;

            panelWelcome.Visible = true;
            var pengguna = LoginContext.Pengguna;
            labelPengguna.Text = pengguna.Nama;
            labelRole.Text = pengguna.Role.NamaRole;

            this.ParentForm.GetRights();
        }
    }
}
