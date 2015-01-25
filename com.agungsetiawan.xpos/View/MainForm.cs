using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using com.agungsetiawan.xpos.View.VBarang;
using com.agungsetiawan.xpos.View.VKategori;

namespace com.agungsetiawan.xpos.View
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
            xtraTabbedMdiManager.MdiParent = this;
        }

        private void navBarDataBarang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ListBarang form = new ListBarang();
            form.MdiParent = this;
            form.Show();
        }

        private void navBarDataKategori_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ListKategori form = new ListKategori();
            form.MdiParent = this;
            form.Show();
        }
    }
}