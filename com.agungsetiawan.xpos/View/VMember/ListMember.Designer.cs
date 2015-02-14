namespace com.agungsetiawan.xpos.View.VMember
{
    partial class ListMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListMember));
            this.dataGridViewMember = new System.Windows.Forms.DataGridView();
            this.btnCetak = new DevExpress.XtraEditors.SimpleButton();
            this.btnHapus = new DevExpress.XtraEditors.SimpleButton();
            this.btnUbah = new DevExpress.XtraEditors.SimpleButton();
            this.btnTambah = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMember)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMember
            // 
            this.dataGridViewMember.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMember.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewMember.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMember.Location = new System.Drawing.Point(-1, 1);
            this.dataGridViewMember.MultiSelect = false;
            this.dataGridViewMember.Name = "dataGridViewMember";
            this.dataGridViewMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMember.Size = new System.Drawing.Size(572, 312);
            this.dataGridViewMember.TabIndex = 5;
            // 
            // btnCetak
            // 
            this.btnCetak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCetak.Image = ((System.Drawing.Image)(resources.GetObject("btnCetak.Image")));
            this.btnCetak.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnCetak.Location = new System.Drawing.Point(317, 319);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(89, 35);
            this.btnCetak.TabIndex = 12;
            this.btnCetak.Text = "Cetak";
            // 
            // btnHapus
            // 
            this.btnHapus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHapus.Image = ((System.Drawing.Image)(resources.GetObject("btnHapus.Image")));
            this.btnHapus.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnHapus.Location = new System.Drawing.Point(218, 319);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(89, 35);
            this.btnHapus.TabIndex = 11;
            this.btnHapus.Text = "Hapus";
            // 
            // btnUbah
            // 
            this.btnUbah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUbah.Image = ((System.Drawing.Image)(resources.GetObject("btnUbah.Image")));
            this.btnUbah.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnUbah.Location = new System.Drawing.Point(118, 319);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(89, 35);
            this.btnUbah.TabIndex = 10;
            this.btnUbah.Text = "Ubah";
            // 
            // btnTambah
            // 
            this.btnTambah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTambah.Image = ((System.Drawing.Image)(resources.GetObject("btnTambah.Image")));
            this.btnTambah.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnTambah.Location = new System.Drawing.Point(14, 319);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(89, 35);
            this.btnTambah.TabIndex = 9;
            this.btnTambah.Text = "Tambah";
            // 
            // ListMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(570, 366);
            this.Controls.Add(this.btnCetak);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.dataGridViewMember);
            this.Name = "ListMember";
            this.Text = "ListMember";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMember)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewMember;
        private DevExpress.XtraEditors.SimpleButton btnCetak;
        private DevExpress.XtraEditors.SimpleButton btnHapus;
        private DevExpress.XtraEditors.SimpleButton btnUbah;
        private DevExpress.XtraEditors.SimpleButton btnTambah;
    }
}