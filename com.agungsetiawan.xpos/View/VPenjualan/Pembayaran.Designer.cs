namespace com.agungsetiawan.xpos.View.VPenjualan
{
    partial class Pembayaran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pembayaran));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelTerbilang = new System.Windows.Forms.Label();
            this.textBoxJumlahBayar = new System.Windows.Forms.TextBox();
            this.textBoxSisa = new System.Windows.Forms.TextBox();
            this.btnSimpan = new DevExpress.XtraEditors.SimpleButton();
            this.btnBatal = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl1.Controls.Add(this.btnBatal);
            this.panelControl1.Controls.Add(this.btnSimpan);
            this.panelControl1.Location = new System.Drawing.Point(1, 213);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(754, 58);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(156)))), ((int)(((byte)(227)))));
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl2.Controls.Add(this.labelTerbilang);
            this.panelControl2.Controls.Add(this.labelTotal);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Location = new System.Drawing.Point(39, 21);
            this.panelControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.panelControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(674, 100);
            this.panelControl2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total";
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotal.Font = new System.Drawing.Font("Tahoma", 25F);
            this.labelTotal.ForeColor = System.Drawing.Color.White;
            this.labelTotal.Location = new System.Drawing.Point(282, 3);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelTotal.Size = new System.Drawing.Size(384, 35);
            this.labelTotal.TabIndex = 1;
            this.labelTotal.Text = "120.000,00";
            // 
            // labelTerbilang
            // 
            this.labelTerbilang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTerbilang.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Italic);
            this.labelTerbilang.ForeColor = System.Drawing.Color.White;
            this.labelTerbilang.Location = new System.Drawing.Point(270, 51);
            this.labelTerbilang.Name = "labelTerbilang";
            this.labelTerbilang.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelTerbilang.Size = new System.Drawing.Size(384, 35);
            this.labelTerbilang.TabIndex = 2;
            this.labelTerbilang.Text = "Seratus Dua Puluh Ribu Rupiah";
            // 
            // textBoxJumlahBayar
            // 
            this.textBoxJumlahBayar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxJumlahBayar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxJumlahBayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxJumlahBayar.Location = new System.Drawing.Point(474, 146);
            this.textBoxJumlahBayar.Name = "textBoxJumlahBayar";
            this.textBoxJumlahBayar.Size = new System.Drawing.Size(240, 20);
            this.textBoxJumlahBayar.TabIndex = 2;
            this.textBoxJumlahBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxJumlahBayar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxJumlahBayar_KeyPress);
            // 
            // textBoxSisa
            // 
            this.textBoxSisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSisa.Location = new System.Drawing.Point(474, 174);
            this.textBoxSisa.Name = "textBoxSisa";
            this.textBoxSisa.Size = new System.Drawing.Size(240, 20);
            this.textBoxSisa.TabIndex = 3;
            this.textBoxSisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSimpan.Image = ((System.Drawing.Image)(resources.GetObject("btnSimpan.Image")));
            this.btnSimpan.Location = new System.Drawing.Point(511, 9);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(92, 34);
            this.btnSimpan.TabIndex = 0;
            this.btnSimpan.Text = "Simpan";
            // 
            // btnBatal
            // 
            this.btnBatal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBatal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBatal.Image = ((System.Drawing.Image)(resources.GetObject("btnBatal.Image")));
            this.btnBatal.Location = new System.Drawing.Point(620, 9);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(92, 34);
            this.btnBatal.TabIndex = 1;
            this.btnBatal.Text = "Batal";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(101)))), ((int)(((byte)(150)))));
            this.label2.Location = new System.Drawing.Point(388, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Jumlah Bayar";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(101)))), ((int)(((byte)(150)))));
            this.label3.Location = new System.Drawing.Point(388, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kembali";
            // 
            // Pembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            this.CancelButton = this.btnBatal;
            this.ClientSize = new System.Drawing.Size(756, 268);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSisa);
            this.Controls.Add(this.textBoxJumlahBayar);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "Pembayaran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pembayaran";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTerbilang;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxJumlahBayar;
        private System.Windows.Forms.TextBox textBoxSisa;
        private DevExpress.XtraEditors.SimpleButton btnSimpan;
        private DevExpress.XtraEditors.SimpleButton btnBatal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}