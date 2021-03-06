﻿using com.agungsetiawan.xpos.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com.agungsetiawan.xpos.View.VMember
{
    public partial class UbahMember : Form
    {
        public ListMember ParentForm { get; set; }
        MemberService memberService;
        public UbahMember()
        {
            InitializeComponent();
            memberService = new MemberService();

            this.ActiveControl = this.textBoxNamaMember;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            bool IsPass = true;

            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(textBoxNamaMember.Text))
            {
                IsPass = false;
                sb.Append("- Nama Member Harus diisi \n");
            }

            if (string.IsNullOrEmpty(textBoxDiskon.Text))
            {
                IsPass = false;
                sb.Append("- Diskon Harus diisi \n");
            }

            if (!string.IsNullOrEmpty(textBoxDiskon.Text))
            {
                float result;
                bool IsHargaJualPass = float.TryParse(textBoxDiskon.Text, out result);
                if (!IsHargaJualPass)
                {
                    IsPass = false;
                    sb.Append("- Diskon harus angka \n");
                }
            }

            if (!IsPass)
            {
                MessageBox.Show(sb.ToString(), "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var member = memberService.Get(int.Parse(labelIdHidden.Text));
            member.NamaMember = textBoxNamaMember.Text;
            member.Diskon = float.Parse(textBoxDiskon.Text);

            memberService.Put(member);

            this.ParentForm.dataGridViewMember.DataSource = memberService.Get();
            this.Dispose();
        }

        public void PopulateData()
        {
            int id = int.Parse(this.ParentForm.dataGridViewMember.SelectedRows[0].Cells[0].Value.ToString());
            var member = memberService.Get(id);

            textBoxNamaMember.Text = member.NamaMember;
            textBoxDiskon.Text = member.Diskon.ToString();
            labelIdHidden.Text = member.Id.ToString();
        }

        private void UbahMember_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Rectangle rectNamaMember = new Rectangle(panelNamaMember.Location.X, panelNamaMember.Location.Y,
                                                         panelNamaMember.ClientSize.Width, panelNamaMember.ClientSize.Height);

            System.Drawing.Rectangle rectDiskon = new Rectangle(panelDiskon.Location.X, panelDiskon.Location.Y,
                                                          panelDiskon.ClientSize.Width, panelDiskon.ClientSize.Height);

            rectNamaMember.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectNamaMember, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);

            rectDiskon.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectDiskon, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);
        }
    }
}
