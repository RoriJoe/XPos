namespace com.agungsetiawan.xpos.View.VTransaksiInternal
{
    partial class ListTransaksiInternal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListTransaksiInternal));
            this.dataGridViewTransaksiInternal = new System.Windows.Forms.DataGridView();
            this.btnUbah = new DevExpress.XtraEditors.SimpleButton();
            this.btnHapus = new DevExpress.XtraEditors.SimpleButton();
            this.btnTambah = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaksiInternal)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTransaksiInternal
            // 
            this.dataGridViewTransaksiInternal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTransaksiInternal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewTransaksiInternal.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewTransaksiInternal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTransaksiInternal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransaksiInternal.Location = new System.Drawing.Point(0, 1);
            this.dataGridViewTransaksiInternal.MultiSelect = false;
            this.dataGridViewTransaksiInternal.Name = "dataGridViewTransaksiInternal";
            this.dataGridViewTransaksiInternal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTransaksiInternal.Size = new System.Drawing.Size(710, 317);
            this.dataGridViewTransaksiInternal.TabIndex = 7;
            // 
            // btnUbah
            // 
            this.btnUbah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUbah.Image = ((System.Drawing.Image)(resources.GetObject("btnUbah.Image")));
            this.btnUbah.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnUbah.Location = new System.Drawing.Point(117, 324);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(89, 35);
            this.btnUbah.TabIndex = 9;
            this.btnUbah.Text = "Ubah";
            // 
            // btnHapus
            // 
            this.btnHapus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHapus.Image = ((System.Drawing.Image)(resources.GetObject("btnHapus.Image")));
            this.btnHapus.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnHapus.Location = new System.Drawing.Point(221, 324);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(89, 35);
            this.btnHapus.TabIndex = 10;
            this.btnHapus.Text = "Hapus";
            // 
            // btnTambah
            // 
            this.btnTambah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTambah.Image = ((System.Drawing.Image)(resources.GetObject("btnTambah.Image")));
            this.btnTambah.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnTambah.Location = new System.Drawing.Point(12, 324);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(89, 35);
            this.btnTambah.TabIndex = 8;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // ListTransaksiInternal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 371);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.dataGridViewTransaksiInternal);
            this.Name = "ListTransaksiInternal";
            this.Text = "ListTransaksiInternal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaksiInternal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewTransaksiInternal;
        private DevExpress.XtraEditors.SimpleButton btnUbah;
        private DevExpress.XtraEditors.SimpleButton btnHapus;
        private DevExpress.XtraEditors.SimpleButton btnTambah;

    }
}