namespace com.agungsetiawan.xpos.View.VPembelian
{
    partial class TransaksiPembelian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransaksiPembelian));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBatal = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSimpan = new DevExpress.XtraEditors.SimpleButton();
            this.textBoxKaryawan = new System.Windows.Forms.TextBox();
            this.textBoxKodeSupplier = new System.Windows.Forms.TextBox();
            this.textBoxSupplier = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSisa = new System.Windows.Forms.TextBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelTerbilang = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panelSupplier = new System.Windows.Forms.Panel();
            this.buttonSupplier = new System.Windows.Forms.Button();
            this.panelKaryawan = new System.Windows.Forms.Panel();
            this.panelKodeSupplier = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxJumlahBayar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTanggal = new System.Windows.Forms.Panel();
            this.textBoxTanggal = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelKodeTransaksi = new System.Windows.Forms.Panel();
            this.textBoxKodeTransaksi = new System.Windows.Forms.TextBox();
            this.Ukuran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTotal = new System.Windows.Forms.Label();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTransaksiPembelian = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.panelSupplier.SuspendLayout();
            this.panelKaryawan.SuspendLayout();
            this.panelKodeSupplier.SuspendLayout();
            this.panelTanggal.SuspendLayout();
            this.panelKodeTransaksi.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaksiPembelian)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBatal
            // 
            this.btnBatal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBatal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBatal.Image = ((System.Drawing.Image)(resources.GetObject("btnBatal.Image")));
            this.btnBatal.Location = new System.Drawing.Point(307, 9);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(92, 34);
            this.btnBatal.TabIndex = 1;
            this.btnBatal.Text = "Batal";
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl1.Controls.Add(this.btnBatal);
            this.panelControl1.Controls.Add(this.btnSimpan);
            this.panelControl1.Location = new System.Drawing.Point(571, 596);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(441, 58);
            this.panelControl1.TabIndex = 47;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSimpan.Image = ((System.Drawing.Image)(resources.GetObject("btnSimpan.Image")));
            this.btnSimpan.Location = new System.Drawing.Point(198, 9);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(92, 34);
            this.btnSimpan.TabIndex = 0;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // textBoxKaryawan
            // 
            this.textBoxKaryawan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKaryawan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKaryawan.Location = new System.Drawing.Point(6, 5);
            this.textBoxKaryawan.Name = "textBoxKaryawan";
            this.textBoxKaryawan.Size = new System.Drawing.Size(158, 13);
            this.textBoxKaryawan.TabIndex = 7;
            // 
            // textBoxKodeSupplier
            // 
            this.textBoxKodeSupplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKodeSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKodeSupplier.Location = new System.Drawing.Point(6, 5);
            this.textBoxKodeSupplier.Name = "textBoxKodeSupplier";
            this.textBoxKodeSupplier.Size = new System.Drawing.Size(132, 13);
            this.textBoxKodeSupplier.TabIndex = 7;
            // 
            // textBoxSupplier
            // 
            this.textBoxSupplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSupplier.Location = new System.Drawing.Point(6, 5);
            this.textBoxSupplier.Name = "textBoxSupplier";
            this.textBoxSupplier.Size = new System.Drawing.Size(158, 13);
            this.textBoxSupplier.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(101)))), ((int)(((byte)(150)))));
            this.label6.Location = new System.Drawing.Point(686, 541);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Kembali";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(101)))), ((int)(((byte)(150)))));
            this.label7.Location = new System.Drawing.Point(686, 497);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Jumlah Bayar";
            // 
            // textBoxSisa
            // 
            this.textBoxSisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxSisa.Location = new System.Drawing.Point(769, 541);
            this.textBoxSisa.Name = "textBoxSisa";
            this.textBoxSisa.Size = new System.Drawing.Size(240, 38);
            this.textBoxSisa.TabIndex = 44;
            this.textBoxSisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(156)))), ((int)(((byte)(227)))));
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl2.Controls.Add(this.labelTerbilang);
            this.panelControl2.Controls.Add(this.label9);
            this.panelControl2.Location = new System.Drawing.Point(571, 400);
            this.panelControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.panelControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(440, 84);
            this.panelControl2.TabIndex = 42;
            // 
            // labelTerbilang
            // 
            this.labelTerbilang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTerbilang.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic);
            this.labelTerbilang.ForeColor = System.Drawing.Color.White;
            this.labelTerbilang.Location = new System.Drawing.Point(23, 28);
            this.labelTerbilang.Name = "labelTerbilang";
            this.labelTerbilang.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelTerbilang.Size = new System.Drawing.Size(414, 39);
            this.labelTerbilang.TabIndex = 2;
            this.labelTerbilang.Text = "Nol Rupiah";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Italic);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(4, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Total";
            // 
            // panelSupplier
            // 
            this.panelSupplier.BackColor = System.Drawing.SystemColors.Window;
            this.panelSupplier.Controls.Add(this.textBoxSupplier);
            this.panelSupplier.Location = new System.Drawing.Point(425, 63);
            this.panelSupplier.Name = "panelSupplier";
            this.panelSupplier.Padding = new System.Windows.Forms.Padding(3);
            this.panelSupplier.Size = new System.Drawing.Size(170, 22);
            this.panelSupplier.TabIndex = 35;
            // 
            // buttonSupplier
            // 
            this.buttonSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.buttonSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupplier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSupplier.Location = new System.Drawing.Point(571, 35);
            this.buttonSupplier.Name = "buttonSupplier";
            this.buttonSupplier.Size = new System.Drawing.Size(26, 23);
            this.buttonSupplier.TabIndex = 41;
            this.buttonSupplier.Text = "...";
            this.buttonSupplier.UseVisualStyleBackColor = false;
            this.buttonSupplier.Click += new System.EventHandler(this.buttonSupplier_Click);
            // 
            // panelKaryawan
            // 
            this.panelKaryawan.BackColor = System.Drawing.SystemColors.Window;
            this.panelKaryawan.Controls.Add(this.textBoxKaryawan);
            this.panelKaryawan.Location = new System.Drawing.Point(425, 7);
            this.panelKaryawan.Name = "panelKaryawan";
            this.panelKaryawan.Padding = new System.Windows.Forms.Padding(3);
            this.panelKaryawan.Size = new System.Drawing.Size(170, 22);
            this.panelKaryawan.TabIndex = 34;
            // 
            // panelKodeSupplier
            // 
            this.panelKodeSupplier.BackColor = System.Drawing.SystemColors.Window;
            this.panelKodeSupplier.Controls.Add(this.textBoxKodeSupplier);
            this.panelKodeSupplier.Location = new System.Drawing.Point(425, 36);
            this.panelKodeSupplier.Name = "panelKodeSupplier";
            this.panelKodeSupplier.Padding = new System.Windows.Forms.Padding(3);
            this.panelKodeSupplier.Size = new System.Drawing.Size(144, 22);
            this.panelKodeSupplier.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Supplier";
            // 
            // textBoxJumlahBayar
            // 
            this.textBoxJumlahBayar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxJumlahBayar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxJumlahBayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxJumlahBayar.Location = new System.Drawing.Point(769, 497);
            this.textBoxJumlahBayar.Name = "textBoxJumlahBayar";
            this.textBoxJumlahBayar.Size = new System.Drawing.Size(240, 38);
            this.textBoxJumlahBayar.TabIndex = 43;
            this.textBoxJumlahBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxJumlahBayar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxJumlahBayar_KeyPress);
            this.textBoxJumlahBayar.Leave += new System.EventHandler(this.textBoxJumlahBayar_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Karyawan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Kode Transaksi";
            // 
            // panelTanggal
            // 
            this.panelTanggal.BackColor = System.Drawing.SystemColors.Control;
            this.panelTanggal.Controls.Add(this.textBoxTanggal);
            this.panelTanggal.Location = new System.Drawing.Point(130, 36);
            this.panelTanggal.Name = "panelTanggal";
            this.panelTanggal.Padding = new System.Windows.Forms.Padding(3);
            this.panelTanggal.Size = new System.Drawing.Size(170, 22);
            this.panelTanggal.TabIndex = 33;
            // 
            // textBoxTanggal
            // 
            this.textBoxTanggal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTanggal.Enabled = false;
            this.textBoxTanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTanggal.Location = new System.Drawing.Point(6, 5);
            this.textBoxTanggal.Name = "textBoxTanggal";
            this.textBoxTanggal.Size = new System.Drawing.Size(158, 13);
            this.textBoxTanggal.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Kode";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nama Barang";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // panelKodeTransaksi
            // 
            this.panelKodeTransaksi.BackColor = System.Drawing.SystemColors.Control;
            this.panelKodeTransaksi.Controls.Add(this.textBoxKodeTransaksi);
            this.panelKodeTransaksi.Location = new System.Drawing.Point(130, 7);
            this.panelKodeTransaksi.Name = "panelKodeTransaksi";
            this.panelKodeTransaksi.Padding = new System.Windows.Forms.Padding(3);
            this.panelKodeTransaksi.Size = new System.Drawing.Size(170, 22);
            this.panelKodeTransaksi.TabIndex = 32;
            // 
            // textBoxKodeTransaksi
            // 
            this.textBoxKodeTransaksi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKodeTransaksi.Enabled = false;
            this.textBoxKodeTransaksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKodeTransaksi.Location = new System.Drawing.Point(6, 5);
            this.textBoxKodeTransaksi.Name = "textBoxKodeTransaksi";
            this.textBoxKodeTransaksi.Size = new System.Drawing.Size(158, 13);
            this.textBoxKodeTransaksi.TabIndex = 7;
            // 
            // Ukuran
            // 
            this.Ukuran.HeaderText = "Ukuran";
            this.Ukuran.Name = "Ukuran";
            this.Ukuran.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 675);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1039, 43);
            this.panel2.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(249)))), ((int)(((byte)(253)))));
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "[F5]=Bayar | [F6]=Cari Supplier | [F7]=Cari Barang | [F8]=Custom Harga | [Del]=Ha" +
    "pus  |  [F11]=Minus  |  [F12]=Tambah    ";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Jumlah Jual";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Tanggal";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Harga Jual";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.panel1.Controls.Add(this.labelTotal);
            this.panel1.Location = new System.Drawing.Point(3, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 100);
            this.panel1.TabIndex = 30;
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.labelTotal.Font = new System.Drawing.Font("Meiryo UI", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(249)))), ((int)(((byte)(253)))));
            this.labelTotal.Location = new System.Drawing.Point(556, 4);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(452, 87);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "0.00";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Subtotal";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Diskon (%)";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // dataGridViewTransaksiPembelian
            // 
            this.dataGridViewTransaksiPembelian.AllowUserToAddRows = false;
            this.dataGridViewTransaksiPembelian.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTransaksiPembelian.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewTransaksiPembelian.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(113)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTransaksiPembelian.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTransaksiPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransaksiPembelian.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Ukuran,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewTransaksiPembelian.EnableHeadersVisualStyles = false;
            this.dataGridViewTransaksiPembelian.Location = new System.Drawing.Point(3, 207);
            this.dataGridViewTransaksiPembelian.Name = "dataGridViewTransaksiPembelian";
            this.dataGridViewTransaksiPembelian.Size = new System.Drawing.Size(1039, 268);
            this.dataGridViewTransaksiPembelian.TabIndex = 29;
            this.dataGridViewTransaksiPembelian.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewTransaksiPembelian_EditingControlShowing);
            this.dataGridViewTransaksiPembelian.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewTransaksiPembelian_KeyDown);
            // 
            // TransaksiPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1045, 725);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxSisa);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelSupplier);
            this.Controls.Add(this.buttonSupplier);
            this.Controls.Add(this.panelKaryawan);
            this.Controls.Add(this.panelKodeSupplier);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxJumlahBayar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelTanggal);
            this.Controls.Add(this.panelKodeTransaksi);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewTransaksiPembelian);
            this.Name = "TransaksiPembelian";
            this.Text = "Transaksi Pembelian";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TransaksiPembelian_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.panelSupplier.ResumeLayout(false);
            this.panelSupplier.PerformLayout();
            this.panelKaryawan.ResumeLayout(false);
            this.panelKaryawan.PerformLayout();
            this.panelKodeSupplier.ResumeLayout(false);
            this.panelKodeSupplier.PerformLayout();
            this.panelTanggal.ResumeLayout(false);
            this.panelTanggal.PerformLayout();
            this.panelKodeTransaksi.ResumeLayout(false);
            this.panelKodeTransaksi.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaksiPembelian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnBatal;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSimpan;
        private System.Windows.Forms.TextBox textBoxKaryawan;
        public System.Windows.Forms.TextBox textBoxKodeSupplier;
        public System.Windows.Forms.TextBox textBoxSupplier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSisa;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        public System.Windows.Forms.Label labelTerbilang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelSupplier;
        private System.Windows.Forms.Button buttonSupplier;
        private System.Windows.Forms.Panel panelKaryawan;
        private System.Windows.Forms.Panel panelKodeSupplier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxJumlahBayar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelTanggal;
        private System.Windows.Forms.TextBox textBoxTanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Panel panelKodeTransaksi;
        public System.Windows.Forms.TextBox textBoxKodeTransaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ukuran;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        public System.Windows.Forms.DataGridView dataGridViewTransaksiPembelian;
    }
}