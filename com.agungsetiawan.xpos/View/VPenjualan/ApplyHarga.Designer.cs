namespace com.agungsetiawan.xpos.View.VPenjualan
{
    partial class ApplyHarga
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
            this.textBoxHarga = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxHarga
            // 
            this.textBoxHarga.Location = new System.Drawing.Point(46, 30);
            this.textBoxHarga.Name = "textBoxHarga";
            this.textBoxHarga.Size = new System.Drawing.Size(284, 20);
            this.textBoxHarga.TabIndex = 0;
            this.textBoxHarga.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxHarga_KeyDown);
            // 
            // ApplyHarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 83);
            this.Controls.Add(this.textBoxHarga);
            this.Name = "ApplyHarga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ApplyHarga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxHarga;
    }
}