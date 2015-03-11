namespace com.agungsetiawan.xpos.View.VPenjualan
{
    partial class ListPenjualan
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
            this.dataGridViewDaftarPenjualan = new System.Windows.Forms.DataGridView();
            this.dataGridViewDaftarPenjualanDetail = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarPenjualan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarPenjualanDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDaftarPenjualan
            // 
            this.dataGridViewDaftarPenjualan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDaftarPenjualan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewDaftarPenjualan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewDaftarPenjualan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDaftarPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaftarPenjualan.Location = new System.Drawing.Point(-3, -3);
            this.dataGridViewDaftarPenjualan.Name = "dataGridViewDaftarPenjualan";
            this.dataGridViewDaftarPenjualan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDaftarPenjualan.Size = new System.Drawing.Size(989, 225);
            this.dataGridViewDaftarPenjualan.TabIndex = 0;
            this.dataGridViewDaftarPenjualan.SelectionChanged += new System.EventHandler(this.dataGridViewDaftarPenjualan_SelectionChanged);
            // 
            // dataGridViewDaftarPenjualanDetail
            // 
            this.dataGridViewDaftarPenjualanDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDaftarPenjualanDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewDaftarPenjualanDetail.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewDaftarPenjualanDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDaftarPenjualanDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaftarPenjualanDetail.Location = new System.Drawing.Point(-3, 271);
            this.dataGridViewDaftarPenjualanDetail.Name = "dataGridViewDaftarPenjualanDetail";
            this.dataGridViewDaftarPenjualanDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDaftarPenjualanDetail.Size = new System.Drawing.Size(989, 236);
            this.dataGridViewDaftarPenjualanDetail.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.panel1.Location = new System.Drawing.Point(-3, 227);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 38);
            this.panel1.TabIndex = 3;
            // 
            // ListPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(983, 555);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewDaftarPenjualanDetail);
            this.Controls.Add(this.dataGridViewDaftarPenjualan);
            this.Name = "ListPenjualan";
            this.Text = "ListPenjualan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarPenjualan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarPenjualanDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDaftarPenjualan;
        private System.Windows.Forms.DataGridView dataGridViewDaftarPenjualanDetail;
        private System.Windows.Forms.Panel panel1;
    }
}