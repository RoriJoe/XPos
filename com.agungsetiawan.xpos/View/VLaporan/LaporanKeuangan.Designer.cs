namespace com.agungsetiawan.xpos.View.VLaporan
{
    partial class LaporanKeuangan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaporanKeuangan));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCetakTransaksiPenjualan = new DevExpress.XtraEditors.SimpleButton();
            this.dateTimePickerTransaksiPenjualan = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCetakBukuBesar = new DevExpress.XtraEditors.SimpleButton();
            this.dateTimePickerBukuBesar = new System.Windows.Forms.DateTimePicker();
            this.checkBoxTanggalSampai = new System.Windows.Forms.CheckBox();
            this.dateTimePickerTransaksiPenjualanSampai = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(751, 269);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dateTimePickerTransaksiPenjualanSampai);
            this.tabPage1.Controls.Add(this.checkBoxTanggalSampai);
            this.tabPage1.Controls.Add(this.btnCetakTransaksiPenjualan);
            this.tabPage1.Controls.Add(this.dateTimePickerTransaksiPenjualan);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(743, 243);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Transaksi Penjualan";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCetakTransaksiPenjualan
            // 
            this.btnCetakTransaksiPenjualan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCetakTransaksiPenjualan.Image = ((System.Drawing.Image)(resources.GetObject("btnCetakTransaksiPenjualan.Image")));
            this.btnCetakTransaksiPenjualan.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnCetakTransaksiPenjualan.Location = new System.Drawing.Point(83, 84);
            this.btnCetakTransaksiPenjualan.Name = "btnCetakTransaksiPenjualan";
            this.btnCetakTransaksiPenjualan.Size = new System.Drawing.Size(89, 35);
            this.btnCetakTransaksiPenjualan.TabIndex = 5;
            this.btnCetakTransaksiPenjualan.Text = "Cetak";
            this.btnCetakTransaksiPenjualan.Click += new System.EventHandler(this.btnCetakTransaksiPenjualan_Click);
            // 
            // dateTimePickerTransaksiPenjualan
            // 
            this.dateTimePickerTransaksiPenjualan.Location = new System.Drawing.Point(6, 6);
            this.dateTimePickerTransaksiPenjualan.Name = "dateTimePickerTransaksiPenjualan";
            this.dateTimePickerTransaksiPenjualan.Size = new System.Drawing.Size(166, 20);
            this.dateTimePickerTransaksiPenjualan.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCetakBukuBesar);
            this.tabPage2.Controls.Add(this.dateTimePickerBukuBesar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(743, 243);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Buku Besar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCetakBukuBesar
            // 
            this.btnCetakBukuBesar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCetakBukuBesar.Image = ((System.Drawing.Image)(resources.GetObject("btnCetakBukuBesar.Image")));
            this.btnCetakBukuBesar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnCetakBukuBesar.Location = new System.Drawing.Point(83, 32);
            this.btnCetakBukuBesar.Name = "btnCetakBukuBesar";
            this.btnCetakBukuBesar.Size = new System.Drawing.Size(89, 35);
            this.btnCetakBukuBesar.TabIndex = 7;
            this.btnCetakBukuBesar.Text = "Cetak";
            this.btnCetakBukuBesar.Click += new System.EventHandler(this.btnCetakBukuBesar_Click);
            // 
            // dateTimePickerBukuBesar
            // 
            this.dateTimePickerBukuBesar.Location = new System.Drawing.Point(6, 6);
            this.dateTimePickerBukuBesar.Name = "dateTimePickerBukuBesar";
            this.dateTimePickerBukuBesar.Size = new System.Drawing.Size(166, 20);
            this.dateTimePickerBukuBesar.TabIndex = 6;
            // 
            // checkBoxTanggalSampai
            // 
            this.checkBoxTanggalSampai.AutoSize = true;
            this.checkBoxTanggalSampai.Location = new System.Drawing.Point(83, 44);
            this.checkBoxTanggalSampai.Name = "checkBoxTanggalSampai";
            this.checkBoxTanggalSampai.Size = new System.Drawing.Size(97, 17);
            this.checkBoxTanggalSampai.TabIndex = 6;
            this.checkBoxTanggalSampai.Text = "Pakai Rentang";
            this.checkBoxTanggalSampai.UseVisualStyleBackColor = true;
            this.checkBoxTanggalSampai.CheckedChanged += new System.EventHandler(this.checkBoxTanggalSampai_CheckedChanged);
            // 
            // dateTimePickerTransaksiPenjualanSampai
            // 
            this.dateTimePickerTransaksiPenjualanSampai.Location = new System.Drawing.Point(199, 6);
            this.dateTimePickerTransaksiPenjualanSampai.Name = "dateTimePickerTransaksiPenjualanSampai";
            this.dateTimePickerTransaksiPenjualanSampai.Size = new System.Drawing.Size(166, 20);
            this.dateTimePickerTransaksiPenjualanSampai.TabIndex = 7;
            this.dateTimePickerTransaksiPenjualanSampai.Visible = false;
            // 
            // LaporanKeuangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(775, 421);
            this.Controls.Add(this.tabControl1);
            this.Name = "LaporanKeuangan";
            this.Text = "LaporanKeuangan";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dateTimePickerTransaksiPenjualan;
        private DevExpress.XtraEditors.SimpleButton btnCetakTransaksiPenjualan;
        private DevExpress.XtraEditors.SimpleButton btnCetakBukuBesar;
        private System.Windows.Forms.DateTimePicker dateTimePickerBukuBesar;
        private System.Windows.Forms.CheckBox checkBoxTanggalSampai;
        private System.Windows.Forms.DateTimePicker dateTimePickerTransaksiPenjualanSampai;
    }
}