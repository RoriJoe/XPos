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
using com.agungsetiawan.xpos.View.VWelcome;
using com.agungsetiawan.xpos.View.VLaporan;

namespace com.agungsetiawan.xpos.View
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
            xtraTabbedMdiManager.MdiParent = this;

            LoginAndWelcome loginWelcome = new LoginAndWelcome();
            loginWelcome.MdiParent = this;
            loginWelcome.ParentForm = this;
            loginWelcome.Show();

            //dummy
            //PenggunaRepository penggunaRepository = new PenggunaRepository();
            //var pengguna = penggunaRepository.FindWithRole(4);
            //LoginContext.Pengguna = pengguna;
            //dummy
        }

        public void GetRights()
        {

            var pengguna = LoginContext.Pengguna;
            var permissions = pengguna.Role.Permissions;

            if (permissions.Contains("barang"))
            {
                barBtnDataBarang.Enabled = true;
                navBarDataBarang.Enabled = true;
            }

            if (permissions.Contains("kategori"))
            {
                barBtnDataKategori.Enabled = true;
                navBarDataKategori.Enabled = true;
            }

            if (permissions.Contains("role"))
            {
                barBtnRole.Enabled = true;
                navBarRole.Enabled = true;
            }

            if (permissions.Contains("pengguna"))
            {
                barBtnPengguna.Enabled = true;
                navBarPengguna.Enabled = true;
            }

            if (permissions.Contains("member"))
            {
                navBarMember.Enabled = true;
            }

            if (permissions.Contains("pelanggan"))
            {
                barBtnPelanggan.Enabled = true;
                navBarPelanggan.Enabled = true;
            }

            if (permissions.Contains("supplier"))
            {
                barBtnSupplier.Enabled = true;
                navBarSupplier.Enabled = true;
            }

            if (permissions.Contains("kasir penjualan"))
            {
                barBtnPenjualan.Enabled = true;
                navBarPenjualan.Enabled = true;
            }

            if (permissions.Contains("daftar penjualan"))
            {
                navBarDaftarPenjualan.Enabled = true;
            }

            if (permissions.Contains("kasir pembelian"))
            {
                barBtnPembelian.Enabled = true;
                navBarPembelian.Enabled = true;
            }

            if (permissions.Contains("daftar pembelian"))
            {
                navBarDaftarPembelian.Enabled = true;
            }

            if(permissions.Contains("laporan"))
            {
                barBtnLaporanJumlahTransaksi.Enabled = true;
            }
            //laporan belum

            barBtnLogout.Enabled = true;
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

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barBtnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoginContext.Pengguna = null;

            barBtnDataBarang.Enabled = false;
            navBarDataBarang.Enabled = false;

            barBtnDataKategori.Enabled = false;
            navBarDataKategori.Enabled = false;

            barBtnRole.Enabled = false;
            navBarRole.Enabled = false;

            barBtnPengguna.Enabled = false;
            navBarPengguna.Enabled = false;

            navBarMember.Enabled = false;

            barBtnPelanggan.Enabled = false;
            navBarPelanggan.Enabled = false;

            barBtnSupplier.Enabled = false;
            navBarSupplier.Enabled = false;

            barBtnPenjualan.Enabled = false;
            navBarPenjualan.Enabled = false;

            navBarDaftarPenjualan.Enabled = false;

            barBtnPembelian.Enabled = false;
            navBarPembelian.Enabled = false;

            navBarDaftarPembelian.Enabled = false;

            barBtnLogout.Enabled = false;

            barBtnLaporanJumlahTransaksi.Enabled = false;
            //laporan belum

            int pagesCount = xtraTabbedMdiManager.Pages.Count;
            for(int i=0;i<pagesCount;i++)
            {
                xtraTabbedMdiManager.Pages[0].MdiChild.Close();
            }
  
            LoginAndWelcome loginWelcome = new LoginAndWelcome();
            loginWelcome.MdiParent = this;
            loginWelcome.ParentForm = this;
            loginWelcome.Show();
        }

        private void barBtnLaporan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LaporanPenjualan form = LaporanPenjualan.GetForm();
            form.MdiParent = this;
            form.Show();
            form.Activate();
        }

        private void barBtnPelanggan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ListPelanggan form = ListPelanggan.GetForm();
            form.MdiParent = this;
            form.Show();
            form.Activate();
        }

        private void barBtnSupplier_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ListSupplier form = ListSupplier.GetForm();
            form.MdiParent = this;
            form.Show();
            form.Activate();

        }

        private void navBarRole_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ListRole form = ListRole.GetForm();
            form.MdiParent = this;
            form.Show();
            form.Activate();
        }

        private void navBarPengguna_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ListPengguna form = ListPengguna.GetForm();
            form.MdiParent = this;
            form.Show();
            form.Activate();
        }
    }
}