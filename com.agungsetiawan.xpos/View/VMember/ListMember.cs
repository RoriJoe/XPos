using com.agungsetiawan.xpos.Repository;
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

namespace com.agungsetiawan.xpos.View.VMember
{
    public partial class ListMember : Form
    {
        static ListMember form;
        MemberService memberService;
        private ListMember()
        {
            InitializeComponent();
            memberService = new MemberService();
            var members = memberService.Get();
            dataGridViewMember.DataSource = members;
        }

        public static ListMember GetForm()
        {
            if(form==null || form.IsDisposed)
            {
                form = new ListMember();
            }

            return form;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            TambahMember form = new TambahMember();
            form.ParentForm = this;
            form.ShowDialog();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            UbahMember form = new UbahMember();
            form.ParentForm=this;
            form.PopulateData();
            form.ShowDialog();
        }
    }
}
