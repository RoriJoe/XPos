namespace com.agungsetiawan.xpos.View.VBarang
{
    partial class ListBarang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListBarang));
            this.dataGridViewBarang = new System.Windows.Forms.DataGridView();
            this.btnTambah = new DevExpress.XtraEditors.SimpleButton();
            this.btnUbah = new DevExpress.XtraEditors.SimpleButton();
            this.btnHapus = new DevExpress.XtraEditors.SimpleButton();
            this.btnCetak = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBarang
            // 
            this.dataGridViewBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewBarang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewBarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBarang.Location = new System.Drawing.Point(-2, 0);
            this.dataGridViewBarang.MultiSelect = false;
            this.dataGridViewBarang.Name = "dataGridViewBarang";
            this.dataGridViewBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBarang.Size = new System.Drawing.Size(698, 319);
            this.dataGridViewBarang.TabIndex = 0;
            this.dataGridViewBarang.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewBarang_RowPostPaint);
            // 
            // btnTambah
            // 
            this.btnTambah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTambah.Image = ((System.Drawing.Image)(resources.GetObject("btnTambah.Image")));
            this.btnTambah.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnTambah.Location = new System.Drawing.Point(12, 325);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(89, 35);
            this.btnTambah.TabIndex = 1;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUbah.Image = ((System.Drawing.Image)(resources.GetObject("btnUbah.Image")));
            this.btnUbah.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnUbah.Location = new System.Drawing.Point(117, 325);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(89, 35);
            this.btnUbah.TabIndex = 2;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHapus.Image = ((System.Drawing.Image)(resources.GetObject("btnHapus.Image")));
            this.btnHapus.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnHapus.Location = new System.Drawing.Point(221, 325);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(89, 35);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnCetak
            // 
            this.btnCetak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCetak.Image = ((System.Drawing.Image)(resources.GetObject("btnCetak.Image")));
            this.btnCetak.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnCetak.Location = new System.Drawing.Point(325, 325);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(89, 35);
            this.btnCetak.TabIndex = 4;
            this.btnCetak.Text = "Cetak";
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
            // 
            // ListBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 372);
            this.Controls.Add(this.btnCetak);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.dataGridViewBarang);
            this.Name = "ListBarang";
            this.Text = "Daftar Barang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewBarang;
        private DevExpress.XtraEditors.SimpleButton btnTambah;
        private DevExpress.XtraEditors.SimpleButton btnUbah;
        private DevExpress.XtraEditors.SimpleButton btnHapus;
        private DevExpress.XtraEditors.SimpleButton btnCetak;
    }
}