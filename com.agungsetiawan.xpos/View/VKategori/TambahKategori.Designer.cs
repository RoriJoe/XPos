namespace com.agungsetiawan.xpos.View.VKategori
{
    partial class TambahKategori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TambahKategori));
            this.btnBatal = new DevExpress.XtraEditors.SimpleButton();
            this.btnSimpan = new DevExpress.XtraEditors.SimpleButton();
            this.textBoxKeterangan = new System.Windows.Forms.TextBox();
            this.textBoxNamaKategori = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelNamaKategori = new System.Windows.Forms.Panel();
            this.panelKeterangan = new System.Windows.Forms.Panel();
            this.panelNamaKategori.SuspendLayout();
            this.panelKeterangan.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBatal
            // 
            this.btnBatal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBatal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBatal.Image = ((System.Drawing.Image)(resources.GetObject("btnBatal.Image")));
            this.btnBatal.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnBatal.Location = new System.Drawing.Point(112, 149);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(89, 35);
            this.btnBatal.TabIndex = 29;
            this.btnBatal.Text = "Batal";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSimpan.Image = ((System.Drawing.Image)(resources.GetObject("btnSimpan.Image")));
            this.btnSimpan.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSimpan.Location = new System.Drawing.Point(17, 149);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(89, 35);
            this.btnSimpan.TabIndex = 28;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // textBoxKeterangan
            // 
            this.textBoxKeterangan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKeterangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKeterangan.Location = new System.Drawing.Point(6, 4);
            this.textBoxKeterangan.Name = "textBoxKeterangan";
            this.textBoxKeterangan.Size = new System.Drawing.Size(228, 13);
            this.textBoxKeterangan.TabIndex = 23;
            // 
            // textBoxNamaKategori
            // 
            this.textBoxNamaKategori.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNamaKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNamaKategori.Location = new System.Drawing.Point(6, 4);
            this.textBoxNamaKategori.Name = "textBoxNamaKategori";
            this.textBoxNamaKategori.Size = new System.Drawing.Size(228, 13);
            this.textBoxNamaKategori.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Keterangan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nama Kategori";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(81, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tambah Data Kategori";
            // 
            // panelNamaKategori
            // 
            this.panelNamaKategori.BackColor = System.Drawing.SystemColors.Window;
            this.panelNamaKategori.Controls.Add(this.textBoxNamaKategori);
            this.panelNamaKategori.Location = new System.Drawing.Point(132, 59);
            this.panelNamaKategori.Name = "panelNamaKategori";
            this.panelNamaKategori.Padding = new System.Windows.Forms.Padding(3);
            this.panelNamaKategori.Size = new System.Drawing.Size(240, 22);
            this.panelNamaKategori.TabIndex = 30;
            // 
            // panelKeterangan
            // 
            this.panelKeterangan.BackColor = System.Drawing.SystemColors.Window;
            this.panelKeterangan.Controls.Add(this.textBoxKeterangan);
            this.panelKeterangan.Location = new System.Drawing.Point(132, 89);
            this.panelKeterangan.Name = "panelKeterangan";
            this.panelKeterangan.Padding = new System.Windows.Forms.Padding(3);
            this.panelKeterangan.Size = new System.Drawing.Size(240, 22);
            this.panelKeterangan.TabIndex = 31;
            // 
            // TambahKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBatal;
            this.ClientSize = new System.Drawing.Size(396, 201);
            this.Controls.Add(this.panelKeterangan);
            this.Controls.Add(this.panelNamaKategori);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TambahKategori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TambahKategori";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TambahKategori_Paint);
            this.panelNamaKategori.ResumeLayout(false);
            this.panelNamaKategori.PerformLayout();
            this.panelKeterangan.ResumeLayout(false);
            this.panelKeterangan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnBatal;
        private DevExpress.XtraEditors.SimpleButton btnSimpan;
        private System.Windows.Forms.TextBox textBoxKeterangan;
        private System.Windows.Forms.TextBox textBoxNamaKategori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelNamaKategori;
        private System.Windows.Forms.Panel panelKeterangan;
    }
}