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
    public partial class UbahPelanggan : Form
    {
        public ListPelanggan ParentForm { get; set; }
        MemberService memberService;
        PelangganService pelangganService;
        public UbahPelanggan()
        {
            InitializeComponent();

            memberService = new MemberService();
            pelangganService = new PelangganService();

            comboBoxMember.DataSource = memberService.Get();
            comboBoxMember.DisplayMember = "NamaMember";
            comboBoxMember.ValueMember = "Id";

            this.ActiveControl = this.textBoxNamaPelanggan;
        }

        private void UbahPelanggan_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Rectangle rectNamaPelanggan = new Rectangle(panelNamaPelanggan.Location.X, panelNamaPelanggan.Location.Y,
                                                         panelNamaPelanggan.ClientSize.Width, panelNamaPelanggan.ClientSize.Height);

            System.Drawing.Rectangle rectAlamat = new Rectangle(panelAlamat.Location.X, panelAlamat.Location.Y,
                                                         panelAlamat.ClientSize.Width, panelAlamat.ClientSize.Height);

            System.Drawing.Rectangle rectNomorTelepon = new Rectangle(panelNomorTelepon.Location.X, panelNomorTelepon.Location.Y,
                                                         panelNomorTelepon.ClientSize.Width, panelNomorTelepon.ClientSize.Height);

            System.Drawing.Rectangle rectMember = new Rectangle(comboBoxMember.Location.X, comboBoxMember.Location.Y,
                                                        comboBoxMember.ClientSize.Width, comboBoxMember.ClientSize.Height);

            System.Drawing.Rectangle rectNomotKtp = new Rectangle(panelNomorKtp.Location.X, panelNomorKtp.Location.Y,
                                                         panelNomorKtp.ClientSize.Width, panelNomorKtp.ClientSize.Height);
            
            rectNamaPelanggan.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectNamaPelanggan, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);

            rectAlamat.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectAlamat, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);

            rectNomorTelepon.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectNomorTelepon, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);

            rectMember.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectMember, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);

            rectNomotKtp.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectNomotKtp, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);
        
        }

        public void PopulateData()
        {
            int id = int.Parse(this.ParentForm.dataGridViewPelanggan.SelectedRows[0].Cells[0].Value.ToString());
            var pelanggan = pelangganService.Get(id);

            textBoxNamaPelanggan.Text = pelanggan.NamaPelanggan;
            textBoxNomorKtp.Text = pelanggan.NomorKtp;
            textBoxAlamat.Text = pelanggan.Alamat;
            textBoxNomorTelepon.Text = pelanggan.NoTelepon;
            comboBoxMember.SelectedValue = pelanggan.Member.Id;
            labelIdHidden.Text = pelanggan.Id.ToString();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            bool IsPass = true;
            if (string.IsNullOrEmpty(textBoxNamaPelanggan.Text))
            {
                IsPass = false;
                sb.Append("- Nama Pelanggan harus diisi \n");
            }

            if (string.IsNullOrEmpty(textBoxNomorKtp.Text))
            {
                IsPass = false;
                sb.Append("- Nomor KTP harus diisi \n");
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

            if (comboBoxMember.SelectedValue == null)
            {
                IsPass = false;
                sb.Append("- Member harus diisi \n");
            }

            if (!IsPass)
            {
                MessageBox.Show(sb.ToString(), "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var member = memberService.Get(int.Parse(comboBoxMember.SelectedValue.ToString()));

            var pelanggan = pelangganService.Get(int.Parse(labelIdHidden.Text));

            pelanggan.NamaPelanggan = textBoxNamaPelanggan.Text;
            pelanggan.NomorKtp = textBoxNomorKtp.Text;
            pelanggan.Alamat = textBoxAlamat.Text;
            pelanggan.NoTelepon = textBoxNomorTelepon.Text;
            pelanggan.MemberId = member.Id;

            pelangganService.Put(pelanggan);

            this.ParentForm.dataGridViewPelanggan.DataSource = pelangganService.Get();
            this.Dispose();
        }
    }
}
