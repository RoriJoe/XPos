namespace com.agungsetiawan.xpos.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnDataBarang = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDataKategori = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnPengguna = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnRole = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnPenjualan = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnPembelian = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnLaporanJumlahTransaksi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnLaporanKeuangan = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnPelanggan = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSupplier = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarDataBarang = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarDataKategori = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarRole = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarPengguna = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarMember = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarPenjualan = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarDaftarPenjualan = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarPembelian = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarDaftarPembelian = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarTransaksiInternal = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarTransaksiEksternal = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup4 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarLaporanJumlahTransaksi = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarLaporanKeuangan = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup5 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarPelanggan = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarSupplier = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarMerek = new DevExpress.XtraNavBar.NavBarItem();
            this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.BackColor = System.Drawing.SystemColors.Control;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barBtnDataBarang,
            this.barBtnDataKategori,
            this.barBtnPengguna,
            this.barBtnRole,
            this.barBtnPenjualan,
            this.barBtnPembelian,
            this.barBtnLaporanJumlahTransaksi,
            this.barBtnLaporanKeuangan,
            this.barButtonItem9,
            this.barBtnPelanggan,
            this.barBtnSupplier,
            this.barBtnLogout});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 13;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(796, 142);
            // 
            // barBtnDataBarang
            // 
            this.barBtnDataBarang.Caption = "Data Barang";
            this.barBtnDataBarang.Enabled = false;
            this.barBtnDataBarang.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnDataBarang.Glyph")));
            this.barBtnDataBarang.Id = 1;
            this.barBtnDataBarang.Name = "barBtnDataBarang";
            this.barBtnDataBarang.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnDataBarang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDataBarang_ItemClick);
            // 
            // barBtnDataKategori
            // 
            this.barBtnDataKategori.Caption = "Data Kategori";
            this.barBtnDataKategori.Enabled = false;
            this.barBtnDataKategori.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnDataKategori.Glyph")));
            this.barBtnDataKategori.Id = 2;
            this.barBtnDataKategori.Name = "barBtnDataKategori";
            this.barBtnDataKategori.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnDataKategori.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDataKategori_ItemClick);
            // 
            // barBtnPengguna
            // 
            this.barBtnPengguna.Caption = "Pengguna";
            this.barBtnPengguna.Enabled = false;
            this.barBtnPengguna.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnPengguna.Glyph")));
            this.barBtnPengguna.Id = 3;
            this.barBtnPengguna.Name = "barBtnPengguna";
            this.barBtnPengguna.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnPengguna.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnPengguna_ItemClick);
            // 
            // barBtnRole
            // 
            this.barBtnRole.Caption = "Role";
            this.barBtnRole.Enabled = false;
            this.barBtnRole.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnRole.Glyph")));
            this.barBtnRole.Id = 4;
            this.barBtnRole.Name = "barBtnRole";
            this.barBtnRole.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnRole.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barBtnPenjualan
            // 
            this.barBtnPenjualan.Caption = "Penjualan";
            this.barBtnPenjualan.Enabled = false;
            this.barBtnPenjualan.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnPenjualan.Glyph")));
            this.barBtnPenjualan.Id = 5;
            this.barBtnPenjualan.Name = "barBtnPenjualan";
            this.barBtnPenjualan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnPenjualan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barBtnPembelian
            // 
            this.barBtnPembelian.Caption = "Pembelian";
            this.barBtnPembelian.Enabled = false;
            this.barBtnPembelian.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnPembelian.Glyph")));
            this.barBtnPembelian.Id = 6;
            this.barBtnPembelian.Name = "barBtnPembelian";
            this.barBtnPembelian.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnPembelian.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnPembelian_ItemClick);
            // 
            // barBtnLaporanJumlahTransaksi
            // 
            this.barBtnLaporanJumlahTransaksi.Caption = "Jumlah Transaksi";
            this.barBtnLaporanJumlahTransaksi.Enabled = false;
            this.barBtnLaporanJumlahTransaksi.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnLaporanJumlahTransaksi.Glyph")));
            this.barBtnLaporanJumlahTransaksi.Id = 7;
            this.barBtnLaporanJumlahTransaksi.Name = "barBtnLaporanJumlahTransaksi";
            this.barBtnLaporanJumlahTransaksi.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnLaporanJumlahTransaksi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnLaporan_ItemClick);
            // 
            // barBtnLaporanKeuangan
            // 
            this.barBtnLaporanKeuangan.Caption = "Laporan Keuangan";
            this.barBtnLaporanKeuangan.Enabled = false;
            this.barBtnLaporanKeuangan.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnLaporanKeuangan.Glyph")));
            this.barBtnLaporanKeuangan.Id = 8;
            this.barBtnLaporanKeuangan.Name = "barBtnLaporanKeuangan";
            this.barBtnLaporanKeuangan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnLaporanKeuangan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnLaporanKeuangan_ItemClick);
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Total";
            this.barButtonItem9.Enabled = false;
            this.barButtonItem9.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.Glyph")));
            this.barButtonItem9.Id = 9;
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem9.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem9_ItemClick);
            // 
            // barBtnPelanggan
            // 
            this.barBtnPelanggan.Caption = "Pelanggan";
            this.barBtnPelanggan.Enabled = false;
            this.barBtnPelanggan.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnPelanggan.Glyph")));
            this.barBtnPelanggan.Id = 10;
            this.barBtnPelanggan.Name = "barBtnPelanggan";
            this.barBtnPelanggan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnPelanggan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnPelanggan_ItemClick);
            // 
            // barBtnSupplier
            // 
            this.barBtnSupplier.Caption = "Supplier";
            this.barBtnSupplier.Enabled = false;
            this.barBtnSupplier.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnSupplier.Glyph")));
            this.barBtnSupplier.Id = 11;
            this.barBtnSupplier.Name = "barBtnSupplier";
            this.barBtnSupplier.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnSupplier.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSupplier_ItemClick);
            // 
            // barBtnLogout
            // 
            this.barBtnLogout.AllowRightClickInMenu = false;
            this.barBtnLogout.Caption = "Logout";
            this.barBtnLogout.Enabled = false;
            this.barBtnLogout.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnLogout.Glyph")));
            this.barBtnLogout.Id = 12;
            this.barBtnLogout.Name = "barBtnLogout";
            this.barBtnLogout.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnLogout_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Menu";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnDataBarang);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnDataKategori);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Master Data";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnPengguna);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnRole);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Administrator";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barBtnPenjualan);
            this.ribbonPageGroup3.ItemLinks.Add(this.barBtnPembelian);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Transaksi";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barBtnLaporanJumlahTransaksi);
            this.ribbonPageGroup4.ItemLinks.Add(this.barBtnLaporanKeuangan);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem9);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Laporan";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barBtnPelanggan);
            this.ribbonPageGroup5.ItemLinks.Add(this.barBtnSupplier);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Pihak Kedua";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.AllowTextClipping = false;
            this.ribbonPageGroup6.ItemLinks.Add(this.barBtnLogout);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Sistem";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3,
            this.navBarGroup4,
            this.navBarGroup5});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarDataBarang,
            this.navBarDataKategori,
            this.navBarRole,
            this.navBarPengguna,
            this.navBarMember,
            this.navBarPenjualan,
            this.navBarDaftarPenjualan,
            this.navBarPembelian,
            this.navBarDaftarPembelian,
            this.navBarLaporanJumlahTransaksi,
            this.navBarPelanggan,
            this.navBarSupplier,
            this.navBarMerek,
            this.navBarTransaksiInternal,
            this.navBarLaporanKeuangan,
            this.navBarTransaksiEksternal});
            this.navBarControl1.Location = new System.Drawing.Point(0, 142);
            this.navBarControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 162;
            this.navBarControl1.Size = new System.Drawing.Size(162, 263);
            this.navBarControl1.SkinExplorerBarViewScrollStyle = DevExpress.XtraNavBar.SkinExplorerBarViewScrollStyle.ScrollBar;
            this.navBarControl1.TabIndex = 1;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Master Data";
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarDataBarang),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarDataKategori)});
            this.navBarGroup1.Name = "navBarGroup1";
            this.navBarGroup1.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup1.SmallImage")));
            // 
            // navBarDataBarang
            // 
            this.navBarDataBarang.Caption = "Data Barang";
            this.navBarDataBarang.Enabled = false;
            this.navBarDataBarang.Name = "navBarDataBarang";
            this.navBarDataBarang.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarDataBarang_LinkClicked);
            // 
            // navBarDataKategori
            // 
            this.navBarDataKategori.Caption = "Data Kategori";
            this.navBarDataKategori.Enabled = false;
            this.navBarDataKategori.Name = "navBarDataKategori";
            this.navBarDataKategori.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarDataKategori_LinkClicked);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Administrator";
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarRole),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarPengguna),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarMember)});
            this.navBarGroup2.Name = "navBarGroup2";
            this.navBarGroup2.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup2.SmallImage")));
            // 
            // navBarRole
            // 
            this.navBarRole.Caption = "Role";
            this.navBarRole.Enabled = false;
            this.navBarRole.Name = "navBarRole";
            this.navBarRole.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarRole_LinkClicked);
            // 
            // navBarPengguna
            // 
            this.navBarPengguna.Caption = "Pengguna";
            this.navBarPengguna.Enabled = false;
            this.navBarPengguna.Name = "navBarPengguna";
            this.navBarPengguna.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarPengguna_LinkClicked);
            // 
            // navBarMember
            // 
            this.navBarMember.Caption = "Member";
            this.navBarMember.Enabled = false;
            this.navBarMember.Name = "navBarMember";
            this.navBarMember.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem5_LinkClicked);
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "Transaksi";
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarPenjualan),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarDaftarPenjualan),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarPembelian),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarDaftarPembelian),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarTransaksiInternal),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarTransaksiEksternal)});
            this.navBarGroup3.Name = "navBarGroup3";
            this.navBarGroup3.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup3.SmallImage")));
            // 
            // navBarPenjualan
            // 
            this.navBarPenjualan.Caption = "Penjualan";
            this.navBarPenjualan.Enabled = false;
            this.navBarPenjualan.Name = "navBarPenjualan";
            this.navBarPenjualan.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarPenjualan_LinkClicked);
            // 
            // navBarDaftarPenjualan
            // 
            this.navBarDaftarPenjualan.Caption = "Daftar Penjualan";
            this.navBarDaftarPenjualan.Enabled = false;
            this.navBarDaftarPenjualan.Name = "navBarDaftarPenjualan";
            this.navBarDaftarPenjualan.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem7_LinkClicked);
            // 
            // navBarPembelian
            // 
            this.navBarPembelian.Caption = "Pembelian";
            this.navBarPembelian.Enabled = false;
            this.navBarPembelian.Name = "navBarPembelian";
            this.navBarPembelian.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarPembelian_LinkClicked);
            // 
            // navBarDaftarPembelian
            // 
            this.navBarDaftarPembelian.Caption = "Daftar Pembelian";
            this.navBarDaftarPembelian.Enabled = false;
            this.navBarDaftarPembelian.Name = "navBarDaftarPembelian";
            this.navBarDaftarPembelian.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarDaftarPembelian_LinkClicked);
            // 
            // navBarTransaksiInternal
            // 
            this.navBarTransaksiInternal.Caption = "Transaksi Internal";
            this.navBarTransaksiInternal.Enabled = false;
            this.navBarTransaksiInternal.Name = "navBarTransaksiInternal";
            this.navBarTransaksiInternal.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarTransaksiInternal_LinkClicked);
            // 
            // navBarTransaksiEksternal
            // 
            this.navBarTransaksiEksternal.Caption = "Transaksi Eksternal";
            this.navBarTransaksiEksternal.Enabled = false;
            this.navBarTransaksiEksternal.Name = "navBarTransaksiEksternal";
            this.navBarTransaksiEksternal.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarTransaksiEksternal_LinkClicked);
            // 
            // navBarGroup4
            // 
            this.navBarGroup4.Caption = "Laporan";
            this.navBarGroup4.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarLaporanJumlahTransaksi),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarLaporanKeuangan)});
            this.navBarGroup4.Name = "navBarGroup4";
            this.navBarGroup4.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup4.SmallImage")));
            // 
            // navBarLaporanJumlahTransaksi
            // 
            this.navBarLaporanJumlahTransaksi.Caption = "Jumlah Transaksi";
            this.navBarLaporanJumlahTransaksi.Enabled = false;
            this.navBarLaporanJumlahTransaksi.Name = "navBarLaporanJumlahTransaksi";
            this.navBarLaporanJumlahTransaksi.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarLaporanJumlahTransaksi_LinkClicked);
            // 
            // navBarLaporanKeuangan
            // 
            this.navBarLaporanKeuangan.Caption = "Laporan Keuangan";
            this.navBarLaporanKeuangan.Enabled = false;
            this.navBarLaporanKeuangan.Name = "navBarLaporanKeuangan";
            this.navBarLaporanKeuangan.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarLaporanKeuangan_LinkClicked);
            // 
            // navBarGroup5
            // 
            this.navBarGroup5.Caption = "Pihak Kedua";
            this.navBarGroup5.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarPelanggan),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarSupplier),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarMerek)});
            this.navBarGroup5.Name = "navBarGroup5";
            this.navBarGroup5.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup5.SmallImage")));
            // 
            // navBarPelanggan
            // 
            this.navBarPelanggan.Caption = "Pelanggan";
            this.navBarPelanggan.Enabled = false;
            this.navBarPelanggan.Name = "navBarPelanggan";
            this.navBarPelanggan.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem15_LinkClicked);
            // 
            // navBarSupplier
            // 
            this.navBarSupplier.Caption = "Supplier";
            this.navBarSupplier.Enabled = false;
            this.navBarSupplier.Name = "navBarSupplier";
            this.navBarSupplier.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem16_LinkClicked);
            // 
            // navBarMerek
            // 
            this.navBarMerek.Caption = "Merek";
            this.navBarMerek.Enabled = false;
            this.navBarMerek.Name = "navBarMerek";
            this.navBarMerek.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarMerek_LinkClicked);
            // 
            // xtraTabbedMdiManager
            // 
            this.xtraTabbedMdiManager.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabbedMdiManager.MdiParent = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 405);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "Elshanum XPOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barBtnDataBarang;
        private DevExpress.XtraBars.BarButtonItem barBtnDataKategori;
        private DevExpress.XtraBars.BarButtonItem barBtnPengguna;
        private DevExpress.XtraBars.BarButtonItem barBtnRole;
        private DevExpress.XtraBars.BarButtonItem barBtnPenjualan;
        private DevExpress.XtraBars.BarButtonItem barBtnPembelian;
        private DevExpress.XtraBars.BarButtonItem barBtnLaporanJumlahTransaksi;
        private DevExpress.XtraBars.BarButtonItem barBtnLaporanKeuangan;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barBtnPelanggan;
        private DevExpress.XtraBars.BarButtonItem barBtnSupplier;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navBarDataBarang;
        private DevExpress.XtraNavBar.NavBarItem navBarDataKategori;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem navBarRole;
        private DevExpress.XtraNavBar.NavBarItem navBarPengguna;
        private DevExpress.XtraNavBar.NavBarItem navBarMember;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarItem navBarPenjualan;
        private DevExpress.XtraNavBar.NavBarItem navBarDaftarPenjualan;
        private DevExpress.XtraNavBar.NavBarItem navBarPembelian;
        private DevExpress.XtraNavBar.NavBarItem navBarDaftarPembelian;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup4;
        private DevExpress.XtraNavBar.NavBarItem navBarLaporanJumlahTransaksi;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup5;
        private DevExpress.XtraNavBar.NavBarItem navBarPelanggan;
        private DevExpress.XtraNavBar.NavBarItem navBarSupplier;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager;
        private DevExpress.XtraBars.BarButtonItem barBtnLogout;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraNavBar.NavBarItem navBarMerek;
        private DevExpress.XtraNavBar.NavBarItem navBarTransaksiInternal;
        private DevExpress.XtraNavBar.NavBarItem navBarLaporanKeuangan;
        private DevExpress.XtraNavBar.NavBarItem navBarTransaksiEksternal;
    }
}