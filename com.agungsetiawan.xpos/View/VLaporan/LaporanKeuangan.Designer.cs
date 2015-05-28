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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dateTimePickerTransaksiPenjualanSampai = new System.Windows.Forms.DateTimePicker();
            this.checkBoxTanggalSampai = new System.Windows.Forms.CheckBox();
            this.btnCetakTransaksiPenjualan = new DevExpress.XtraEditors.SimpleButton();
            this.dateTimePickerTransaksiPenjualan = new System.Windows.Forms.DateTimePicker();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dateTimePickerTransaksiPembelianSampai = new System.Windows.Forms.DateTimePicker();
            this.checkBoxTanggalSampaiTransaksiPembelian = new System.Windows.Forms.CheckBox();
            this.btnCetakTransaksiPembelian = new DevExpress.XtraEditors.SimpleButton();
            this.dateTimePickerTransaksiPembelian = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelTotalSaldo = new System.Windows.Forms.Label();
            this.dateTimePickerBukuBesarSampai = new System.Windows.Forms.DateTimePicker();
            this.checkBoxTanggalSampaiBukuBesar = new System.Windows.Forms.CheckBox();
            this.btnCetakBukuBesar = new DevExpress.XtraEditors.SimpleButton();
            this.dateTimePickerBukuBesar = new System.Windows.Forms.DateTimePicker();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chartLabaRugi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLabaRugi)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(751, 397);
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
            this.tabPage1.Size = new System.Drawing.Size(743, 371);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Transaksi Penjualan";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerTransaksiPenjualanSampai
            // 
            this.dateTimePickerTransaksiPenjualanSampai.Location = new System.Drawing.Point(199, 6);
            this.dateTimePickerTransaksiPenjualanSampai.Name = "dateTimePickerTransaksiPenjualanSampai";
            this.dateTimePickerTransaksiPenjualanSampai.Size = new System.Drawing.Size(166, 20);
            this.dateTimePickerTransaksiPenjualanSampai.TabIndex = 7;
            this.dateTimePickerTransaksiPenjualanSampai.Visible = false;
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
            // btnCetakTransaksiPenjualan
            // 
            this.btnCetakTransaksiPenjualan.Image = ((System.Drawing.Image)(resources.GetObject("btnCetakTransaksiPenjualan.Image")));
            this.btnCetakTransaksiPenjualan.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnCetakTransaksiPenjualan.Location = new System.Drawing.Point(83, 80);
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dateTimePickerTransaksiPembelianSampai);
            this.tabPage3.Controls.Add(this.checkBoxTanggalSampaiTransaksiPembelian);
            this.tabPage3.Controls.Add(this.btnCetakTransaksiPembelian);
            this.tabPage3.Controls.Add(this.dateTimePickerTransaksiPembelian);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(743, 371);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Transaksi Pembelian";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerTransaksiPembelianSampai
            // 
            this.dateTimePickerTransaksiPembelianSampai.Location = new System.Drawing.Point(199, 6);
            this.dateTimePickerTransaksiPembelianSampai.Name = "dateTimePickerTransaksiPembelianSampai";
            this.dateTimePickerTransaksiPembelianSampai.Size = new System.Drawing.Size(166, 20);
            this.dateTimePickerTransaksiPembelianSampai.TabIndex = 11;
            this.dateTimePickerTransaksiPembelianSampai.Visible = false;
            // 
            // checkBoxTanggalSampaiTransaksiPembelian
            // 
            this.checkBoxTanggalSampaiTransaksiPembelian.AutoSize = true;
            this.checkBoxTanggalSampaiTransaksiPembelian.Location = new System.Drawing.Point(83, 44);
            this.checkBoxTanggalSampaiTransaksiPembelian.Name = "checkBoxTanggalSampaiTransaksiPembelian";
            this.checkBoxTanggalSampaiTransaksiPembelian.Size = new System.Drawing.Size(97, 17);
            this.checkBoxTanggalSampaiTransaksiPembelian.TabIndex = 10;
            this.checkBoxTanggalSampaiTransaksiPembelian.Text = "Pakai Rentang";
            this.checkBoxTanggalSampaiTransaksiPembelian.UseVisualStyleBackColor = true;
            this.checkBoxTanggalSampaiTransaksiPembelian.CheckedChanged += new System.EventHandler(this.checkBoxTanggalSampaiTransaksiPembelian_CheckedChanged);
            // 
            // btnCetakTransaksiPembelian
            // 
            this.btnCetakTransaksiPembelian.Image = ((System.Drawing.Image)(resources.GetObject("btnCetakTransaksiPembelian.Image")));
            this.btnCetakTransaksiPembelian.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnCetakTransaksiPembelian.Location = new System.Drawing.Point(83, 82);
            this.btnCetakTransaksiPembelian.Name = "btnCetakTransaksiPembelian";
            this.btnCetakTransaksiPembelian.Size = new System.Drawing.Size(89, 35);
            this.btnCetakTransaksiPembelian.TabIndex = 9;
            this.btnCetakTransaksiPembelian.Text = "Cetak";
            this.btnCetakTransaksiPembelian.Click += new System.EventHandler(this.btnCetakTransaksiPembelian_Click);
            // 
            // dateTimePickerTransaksiPembelian
            // 
            this.dateTimePickerTransaksiPembelian.Location = new System.Drawing.Point(6, 6);
            this.dateTimePickerTransaksiPembelian.Name = "dateTimePickerTransaksiPembelian";
            this.dateTimePickerTransaksiPembelian.Size = new System.Drawing.Size(166, 20);
            this.dateTimePickerTransaksiPembelian.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelTotalSaldo);
            this.tabPage2.Controls.Add(this.dateTimePickerBukuBesarSampai);
            this.tabPage2.Controls.Add(this.checkBoxTanggalSampaiBukuBesar);
            this.tabPage2.Controls.Add(this.btnCetakBukuBesar);
            this.tabPage2.Controls.Add(this.dateTimePickerBukuBesar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(743, 371);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Buku Besar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelTotalSaldo
            // 
            this.labelTotalSaldo.AutoSize = true;
            this.labelTotalSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalSaldo.Location = new System.Drawing.Point(6, 144);
            this.labelTotalSaldo.Name = "labelTotalSaldo";
            this.labelTotalSaldo.Size = new System.Drawing.Size(92, 31);
            this.labelTotalSaldo.TabIndex = 10;
            this.labelTotalSaldo.Text = "label1";
            // 
            // dateTimePickerBukuBesarSampai
            // 
            this.dateTimePickerBukuBesarSampai.Location = new System.Drawing.Point(195, 6);
            this.dateTimePickerBukuBesarSampai.Name = "dateTimePickerBukuBesarSampai";
            this.dateTimePickerBukuBesarSampai.Size = new System.Drawing.Size(166, 20);
            this.dateTimePickerBukuBesarSampai.TabIndex = 9;
            this.dateTimePickerBukuBesarSampai.Visible = false;
            // 
            // checkBoxTanggalSampaiBukuBesar
            // 
            this.checkBoxTanggalSampaiBukuBesar.AutoSize = true;
            this.checkBoxTanggalSampaiBukuBesar.Location = new System.Drawing.Point(83, 43);
            this.checkBoxTanggalSampaiBukuBesar.Name = "checkBoxTanggalSampaiBukuBesar";
            this.checkBoxTanggalSampaiBukuBesar.Size = new System.Drawing.Size(97, 17);
            this.checkBoxTanggalSampaiBukuBesar.TabIndex = 8;
            this.checkBoxTanggalSampaiBukuBesar.Text = "Pakai Rentang";
            this.checkBoxTanggalSampaiBukuBesar.UseVisualStyleBackColor = true;
            this.checkBoxTanggalSampaiBukuBesar.CheckedChanged += new System.EventHandler(this.checkBoxTanggalSampaiBukuBesar_CheckedChanged);
            // 
            // btnCetakBukuBesar
            // 
            this.btnCetakBukuBesar.Image = ((System.Drawing.Image)(resources.GetObject("btnCetakBukuBesar.Image")));
            this.btnCetakBukuBesar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnCetakBukuBesar.Location = new System.Drawing.Point(83, 86);
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
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chartLabaRugi);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(743, 371);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Laba/Rugi";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // chartLabaRugi
            // 
            this.chartLabaRugi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartLabaRugi.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartLabaRugi.Legends.Add(legend1);
            this.chartLabaRugi.Location = new System.Drawing.Point(7, 7);
            this.chartLabaRugi.Name = "chartLabaRugi";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartLabaRugi.Series.Add(series1);
            this.chartLabaRugi.Size = new System.Drawing.Size(733, 358);
            this.chartLabaRugi.TabIndex = 0;
            this.chartLabaRugi.Text = "chart1";
            this.chartLabaRugi.FormatNumber += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.FormatNumberEventArgs>(this.chartLabaRugi_FormatNumber);
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
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartLabaRugi)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dateTimePickerBukuBesarSampai;
        private System.Windows.Forms.CheckBox checkBoxTanggalSampaiBukuBesar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DateTimePicker dateTimePickerTransaksiPembelianSampai;
        private System.Windows.Forms.CheckBox checkBoxTanggalSampaiTransaksiPembelian;
        private DevExpress.XtraEditors.SimpleButton btnCetakTransaksiPembelian;
        private System.Windows.Forms.DateTimePicker dateTimePickerTransaksiPembelian;
        private System.Windows.Forms.Label labelTotalSaldo;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLabaRugi;
    }
}