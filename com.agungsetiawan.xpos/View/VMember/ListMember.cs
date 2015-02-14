using com.agungsetiawan.xpos.Repository;
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
        MemberRepository memberRepository;
        private ListMember()
        {
            InitializeComponent();
            memberRepository = new MemberRepository();
            var members = memberRepository.Get();
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
    }
}
