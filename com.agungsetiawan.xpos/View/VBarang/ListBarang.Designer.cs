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
            this.dataGridViewStokUkuran = new System.Windows.Forms.DataGridView();
            this.panelBarang = new System.Windows.Forms.Panel();
            this.textBoxBarang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStokUkuran)).BeginInit();
            this.panelBarang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewBarang
            // 
            this.dataGridViewBarang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewBarang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewBarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBarang.Location = new System.Drawing.Point(-2, 56);
            this.dataGridViewBarang.MultiSelect = false;
            this.dataGridViewBarang.Name = "dataGridViewBarang";
            this.dataGridViewBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBarang.Size = new System.Drawing.Size(994, 169);
            this.dataGridViewBarang.TabIndex = 0;
            this.dataGridViewBarang.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewBarang_RowPostPaint);
            this.dataGridViewBarang.SelectionChanged += new System.EventHandler(this.dataGridViewBarang_SelectionChanged);
            // 
            // btnTambah
            // 
            this.btnTambah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTambah.Image = ((System.Drawing.Image)(resources.GetObject("btnTambah.Image")));
            this.btnTambah.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnTambah.Location = new System.Drawing.Point(12, 436);
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
            this.btnUbah.Location = new System.Drawing.Point(117, 436);
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
            this.btnHapus.Location = new System.Drawing.Point(221, 436);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(89, 35);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // dataGridViewStokUkuran
            // 
            this.dataGridViewStokUkuran.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStokUkuran.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewStokUkuran.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewStokUkuran.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewStokUkuran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStokUkuran.Location = new System.Drawing.Point(3, 275);
            this.dataGridViewStokUkuran.MultiSelect = false;
            this.dataGridViewStokUkuran.Name = "dataGridViewStokUkuran";
            this.dataGridViewStokUkuran.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStokUkuran.Size = new System.Drawing.Size(994, 155);
            this.dataGridViewStokUkuran.TabIndex = 6;
            // 
            // panelBarang
            // 
            this.panelBarang.BackColor = System.Drawing.SystemColors.Window;
            this.panelBarang.Controls.Add(this.textBoxBarang);
            this.panelBarang.Location = new System.Drawing.Point(99, 16);
            this.panelBarang.Name = "panelBarang";
            this.panelBarang.Padding = new System.Windows.Forms.Padding(3);
            this.panelBarang.Size = new System.Drawing.Size(170, 22);
            this.panelBarang.TabIndex = 21;
            // 
            // textBoxBarang
            // 
            this.textBoxBarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBarang.Location = new System.Drawing.Point(6, 5);
            this.textBoxBarang.Name = "textBoxBarang";
            this.textBoxBarang.Size = new System.Drawing.Size(158, 13);
            this.textBoxBarang.TabIndex = 7;
            this.textBoxBarang.TextChanged += new System.EventHandler(this.textBoxBarang_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nama Barang";
            // 
            // btnReset
            // 
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(287, 15);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(64, 23);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.panel1.Location = new System.Drawing.Point(3, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 38);
            this.panel1.TabIndex = 5;
            // 
            // ListBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 483);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.panelBarang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewStokUkuran);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.dataGridViewBarang);
            this.Name = "ListBarang";
            this.Text = "Daftar Barang";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ListBarang_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStokUkuran)).EndInit();
            this.panelBarang.ResumeLayout(false);
            this.panelBarang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewBarang;
        private DevExpress.XtraEditors.SimpleButton btnTambah;
        private DevExpress.XtraEditors.SimpleButton btnUbah;
        private DevExpress.XtraEditors.SimpleButton btnHapus;
        public System.Windows.Forms.DataGridView dataGridViewStokUkuran;
        private System.Windows.Forms.Panel panelBarang;
        private System.Windows.Forms.TextBox textBoxBarang;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnReset;
        private System.Windows.Forms.Panel panel1;
    }
}