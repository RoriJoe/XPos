namespace com.agungsetiawan.xpos.View.VLaporan
{
    partial class LaporanPenjualan
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxJenis = new System.Windows.Forms.ComboBox();
            this.labelKatOrBarang = new System.Windows.Forms.Label();
            this.comboBoxKatOrBarang = new System.Windows.Forms.ComboBox();
            this.chartPenjualan = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnTampil = new DevExpress.XtraEditors.SimpleButton();
            this.btnSummary = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.chartPenjualan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jenis";
            // 
            // comboBoxJenis
            // 
            this.comboBoxJenis.FormattingEnabled = true;
            this.comboBoxJenis.Location = new System.Drawing.Point(95, 10);
            this.comboBoxJenis.Name = "comboBoxJenis";
            this.comboBoxJenis.Size = new System.Drawing.Size(173, 21);
            this.comboBoxJenis.TabIndex = 1;
            this.comboBoxJenis.SelectedValueChanged += new System.EventHandler(this.comboBoxJenis_SelectedValueChanged);
            // 
            // labelKatOrBarang
            // 
            this.labelKatOrBarang.AutoSize = true;
            this.labelKatOrBarang.Location = new System.Drawing.Point(22, 47);
            this.labelKatOrBarang.Name = "labelKatOrBarang";
            this.labelKatOrBarang.Size = new System.Drawing.Size(46, 13);
            this.labelKatOrBarang.TabIndex = 2;
            this.labelKatOrBarang.Text = "Kategori";
            // 
            // comboBoxKatOrBarang
            // 
            this.comboBoxKatOrBarang.FormattingEnabled = true;
            this.comboBoxKatOrBarang.Location = new System.Drawing.Point(95, 44);
            this.comboBoxKatOrBarang.Name = "comboBoxKatOrBarang";
            this.comboBoxKatOrBarang.Size = new System.Drawing.Size(173, 21);
            this.comboBoxKatOrBarang.TabIndex = 3;
            // 
            // chartPenjualan
            // 
            this.chartPenjualan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartPenjualan.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPenjualan.Legends.Add(legend1);
            this.chartPenjualan.Location = new System.Drawing.Point(25, 94);
            this.chartPenjualan.Name = "chartPenjualan";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartPenjualan.Series.Add(series1);
            this.chartPenjualan.Size = new System.Drawing.Size(672, 272);
            this.chartPenjualan.TabIndex = 4;
            this.chartPenjualan.Text = "chart1";
            // 
            // btnTampil
            // 
            this.btnTampil.Location = new System.Drawing.Point(304, 10);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(75, 23);
            this.btnTampil.TabIndex = 5;
            this.btnTampil.Text = "Tampil";
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(304, 42);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(75, 23);
            this.btnSummary.TabIndex = 6;
            this.btnSummary.Text = "Summary";
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // LaporanPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 388);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.btnTampil);
            this.Controls.Add(this.chartPenjualan);
            this.Controls.Add(this.comboBoxKatOrBarang);
            this.Controls.Add(this.labelKatOrBarang);
            this.Controls.Add(this.comboBoxJenis);
            this.Controls.Add(this.label1);
            this.Name = "LaporanPenjualan";
            this.Text = "LaporanPenjualan";
            ((System.ComponentModel.ISupportInitialize)(this.chartPenjualan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxJenis;
        private System.Windows.Forms.Label labelKatOrBarang;
        private System.Windows.Forms.ComboBox comboBoxKatOrBarang;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPenjualan;
        private DevExpress.XtraEditors.SimpleButton btnTampil;
        private DevExpress.XtraEditors.SimpleButton btnSummary;
    }
}