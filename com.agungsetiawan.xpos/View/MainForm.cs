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
using com.agungsetiawan.xpos.View.VPenjualan;
using com.agungsetiawan.xpos.Repository;
using com.agungsetiawan.xpos.Common;
using com.agungsetiawan.xpos.View.VMember;
using com.agungsetiawan.xpos.View.VPelanggan;
using com.agungsetiawan.xpos.View.VSupplier;
using com.agungsetiawan.xpos.View.VRole;
using com.agungsetiawan.xpos.View.VPengguna;

namespace com.agungsetiawan.xpos.View
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
            xtraTabbedMdiManager.MdiParent = this;

            //dummy
            PenggunaRepository penggunaRepository=new PenggunaRepository();
            var pengguna = penggunaRepository.FindWithRole(4);
            LoginContext.Pengguna = pengguna;

            var permissions = pengguna.Role.Permissions;
            
            if(!permissions.Contains("barang"))
            {
                barBtnDataBarang.Enabled = false;
                navBarDataBarang.Enabled = false;
            }

            if (!permissions.Contains("kategori"))
            {
                barBtnDataKategori.Enabled = false;
                navBarDataKategori.Enabled = false;
            }

            if (!permissions.Contains("role"))
            {
                barBtnRole.Enabled = false;
                navBarRole.Enabled = false;
            }

            if (!permissions.Contains("pengguna"))
            {
                barBtnPengguna.Enabled = false;
                navBarPengguna.Enabled = false;
            }

            if (!permissions.Contains("member"))
            {
                navBarMember.Enabled = false;
            }

            if (!permissions.Contains("pelanggan"))
            {
                barBtnPelanggan.Enabled = false;
                navBarPelanggan.Enabled = false;
            }

            if (!permissions.Contains("supplier"))
            {
                barBtnSupplier.Enabled = false;
                navBarSupplier.Enabled = false;
            }

            if (!permissions.Contains("kasir penjualan"))
            {
                barBtnPenjualan.Enabled = false;
                navBarPenjualan.Enabled = false;
            }

            if (!permissions.Contains("daftar penjualan"))
            {
                navBarDaftarPenjualan.Enabled = false;
            }

            if (!permissions.Contains("kasir pembelian"))
            {
                barBtnPembelian.Enabled = false;
                navBarPembelian.Enabled = false;
            }

            if (!permissions.Contains("daftar pembelian"))
            {
                navBarDaftarPembelian.Enabled = false;
            }
            //dummy
        }

        private void navBarDataBarang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ListBarang form = ListBarang.GetForm();
            form.MdiParent = this;
            form.Show();
            form.Activate();
        }

        private void navBarDataKategori_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ListKategori form = ListKategori.GetForm();
            form.MdiParent = this;
            form.Show();
            form.Activate();
        }

        private void barBtnDataBarang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ListBarang form = ListBarang.GetForm();
            form.MdiParent = this;
            form.Show();
            form.Activate();
        }

        private void barBtnDataKategori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ListKategori form = ListKategori.GetForm();
            form.MdiParent = this;
            form.Show();
            form.Activate();
        }

        private void navBarPenjualan_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TransaksiPenjualan form = TransaksiPenjualan.GetForm();
            form.MdiParent = this;

            var IsSuccess = form.PopulateData();
            if(!IsSuccess)
            {
                MessageBox.Show("Buat terlebih dahulu Pelanggan dengan member berdiskon 0 (nol)", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            form.Show();
            form.Activate();
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ListMember form = ListMember.GetForm();
            form.MdiParent = this;
            form.Show();
            form.Activate();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TransaksiPenjualan form = TransaksiPenjualan.GetForm();
            form.MdiParent = this;

            var IsSuccess = form.PopulateData();
            if (!IsSuccess)
            {
                MessageBox.Show("Buat terlebih dahulu Pelanggan dengan member berdiskon 0 (nol)", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            form.Show();
            form.Activate();
        }

        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ListPenjualan form = ListPenjualan.GetForm();
            form.MdiParent = this;
            form.Show();
            form.Activate();
        }

        private void navBarItem15_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ListPelanggan form = ListPelanggan.GetForm();
            form.MdiParent = this;
            form.Show();
            form.Activate();
      
        }

        private void navBarItem16_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ListSupplier form = ListSupplier.GetForm();
            form.MdiParent = this;
            form.Show();
            form.Activate();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ListRole form = ListRole.GetForm();
            form.MdiParent = this;
            form.Show();
            form.Activate();
        }

        private void barBtnPengguna_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ListPengguna form = ListPengguna.GetForm();
            form.MdiParent = this;
            form.Show();
            form.Activate();
        }
    }
}