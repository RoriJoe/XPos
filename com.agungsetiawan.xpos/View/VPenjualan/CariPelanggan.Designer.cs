namespace com.agungsetiawan.xpos.View.VPenjualan
{
    partial class CariPelanggan
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
            this.dataGridViewCariPelanggan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPelanggan = new System.Windows.Forms.Panel();
            this.textBoxPelanggan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCariPelanggan)).BeginInit();
            this.panelPelanggan.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCariPelanggan
            // 
            this.dataGridViewCariPelanggan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCariPelanggan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewCariPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCariPelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCariPelanggan.Location = new System.Drawing.Point(2, 58);
            this.dataGridViewCariPelanggan.Name = "dataGridViewCariPelanggan";
            this.dataGridViewCariPelanggan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCariPelanggan.Size = new System.Drawing.Size(355, 234);
            this.dataGridViewCariPelanggan.TabIndex = 0;
            this.dataGridViewCariPelanggan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewCariPelanggan_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama Pelanggan";
            // 
            // panelPelanggan
            // 
            this.panelPelanggan.BackColor = System.Drawing.SystemColors.Window;
            this.panelPelanggan.Controls.Add(this.textBoxPelanggan);
            this.panelPelanggan.Location = new System.Drawing.Point(108, 13);
            this.panelPelanggan.Name = "panelPelanggan";
            this.panelPelanggan.Padding = new System.Windows.Forms.Padding(3);
            this.panelPelanggan.Size = new System.Drawing.Size(170, 22);
            this.panelPelanggan.TabIndex = 18;
            // 
            // textBoxPelanggan
            // 
            this.textBoxPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPelanggan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPelanggan.Location = new System.Drawing.Point(6, 5);
            this.textBoxPelanggan.Name = "textBoxPelanggan";
            this.textBoxPelanggan.Size = new System.Drawing.Size(158, 13);
            this.textBoxPelanggan.TabIndex = 7;
            this.textBoxPelanggan.TextChanged += new System.EventHandler(this.textBoxPelanggan_TextChanged);
            // 
            // CariPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(356, 290);
            this.Controls.Add(this.panelPelanggan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewCariPelanggan);
            this.Name = "CariPelanggan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CariPelanggan";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CariPelanggan_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCariPelanggan)).EndInit();
            this.panelPelanggan.ResumeLayout(false);
            this.panelPelanggan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCariPelanggan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPelanggan;
        private System.Windows.Forms.TextBox textBoxPelanggan;
    }
}