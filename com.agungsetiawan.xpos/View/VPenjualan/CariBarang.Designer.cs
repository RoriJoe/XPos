namespace com.agungsetiawan.xpos.View.VPenjualan
{
    partial class CariBarang
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
            this.dataGridViewCariBarang = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBarang = new System.Windows.Forms.TextBox();
            this.panelBarang = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCariBarang)).BeginInit();
            this.panelBarang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCariBarang
            // 
            this.dataGridViewCariBarang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCariBarang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewCariBarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCariBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCariBarang.Location = new System.Drawing.Point(1, 72);
            this.dataGridViewCariBarang.MultiSelect = false;
            this.dataGridViewCariBarang.Name = "dataGridViewCariBarang";
            this.dataGridViewCariBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCariBarang.Size = new System.Drawing.Size(749, 351);
            this.dataGridViewCariBarang.TabIndex = 8;
            this.dataGridViewCariBarang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewCariBarang_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nama Barang";
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
            // panelBarang
            // 
            this.panelBarang.BackColor = System.Drawing.SystemColors.Window;
            this.panelBarang.Controls.Add(this.textBoxBarang);
            this.panelBarang.Location = new System.Drawing.Point(108, 22);
            this.panelBarang.Name = "panelBarang";
            this.panelBarang.Padding = new System.Windows.Forms.Padding(3);
            this.panelBarang.Size = new System.Drawing.Size(170, 22);
            this.panelBarang.TabIndex = 19;
            // 
            // CariBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(748, 427);
            this.Controls.Add(this.panelBarang);
            this.Controls.Add(this.dataGridViewCariBarang);
            this.Controls.Add(this.label1);
            this.Name = "CariBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CariBarang";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CariBarang_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCariBarang)).EndInit();
            this.panelBarang.ResumeLayout(false);
            this.panelBarang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCariBarang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBarang;
        private System.Windows.Forms.Panel panelBarang;
    }
}