namespace com.agungsetiawan.xpos.View.VPembelian
{
    partial class CariSupplier
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
            this.panelSupplier = new System.Windows.Forms.Panel();
            this.textBoxSupplier = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewCariSupplier = new System.Windows.Forms.DataGridView();
            this.panelSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCariSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSupplier
            // 
            this.panelSupplier.BackColor = System.Drawing.SystemColors.Window;
            this.panelSupplier.Controls.Add(this.textBoxSupplier);
            this.panelSupplier.Location = new System.Drawing.Point(105, 11);
            this.panelSupplier.Name = "panelSupplier";
            this.panelSupplier.Padding = new System.Windows.Forms.Padding(3);
            this.panelSupplier.Size = new System.Drawing.Size(170, 22);
            this.panelSupplier.TabIndex = 21;
            // 
            // textBoxSupplier
            // 
            this.textBoxSupplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSupplier.Location = new System.Drawing.Point(6, 5);
            this.textBoxSupplier.Name = "textBoxSupplier";
            this.textBoxSupplier.Size = new System.Drawing.Size(158, 13);
            this.textBoxSupplier.TabIndex = 7;
            this.textBoxSupplier.TextChanged += new System.EventHandler(this.textBoxSupplier_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nama Supplier";
            // 
            // dataGridViewCariSupplier
            // 
            this.dataGridViewCariSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCariSupplier.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewCariSupplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCariSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCariSupplier.Location = new System.Drawing.Point(-1, 56);
            this.dataGridViewCariSupplier.Name = "dataGridViewCariSupplier";
            this.dataGridViewCariSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCariSupplier.Size = new System.Drawing.Size(459, 234);
            this.dataGridViewCariSupplier.TabIndex = 19;
            this.dataGridViewCariSupplier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewCariSupplier_KeyDown);
            // 
            // CariSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(457, 300);
            this.Controls.Add(this.panelSupplier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewCariSupplier);
            this.Name = "CariSupplier";
            this.Text = "CariSupplier";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CariSupplier_Paint);
            this.panelSupplier.ResumeLayout(false);
            this.panelSupplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCariSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSupplier;
        private System.Windows.Forms.TextBox textBoxSupplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewCariSupplier;
    }
}