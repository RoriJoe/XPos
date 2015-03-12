namespace com.agungsetiawan.xpos.View.VMember
{
    partial class TambahMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TambahMember));
            this.panelDiskon = new System.Windows.Forms.Panel();
            this.textBoxDiskon = new System.Windows.Forms.TextBox();
            this.panelNamaMember = new System.Windows.Forms.Panel();
            this.textBoxNamaMember = new System.Windows.Forms.TextBox();
            this.btnBatal = new DevExpress.XtraEditors.SimpleButton();
            this.btnSimpan = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDiskon.SuspendLayout();
            this.panelNamaMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDiskon
            // 
            this.panelDiskon.BackColor = System.Drawing.SystemColors.Window;
            this.panelDiskon.Controls.Add(this.textBoxDiskon);
            this.panelDiskon.Location = new System.Drawing.Point(130, 88);
            this.panelDiskon.Name = "panelDiskon";
            this.panelDiskon.Padding = new System.Windows.Forms.Padding(3);
            this.panelDiskon.Size = new System.Drawing.Size(240, 22);
            this.panelDiskon.TabIndex = 31;
            // 
            // textBoxDiskon
            // 
            this.textBoxDiskon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDiskon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiskon.Location = new System.Drawing.Point(6, 4);
            this.textBoxDiskon.Name = "textBoxDiskon";
            this.textBoxDiskon.Size = new System.Drawing.Size(228, 13);
            this.textBoxDiskon.TabIndex = 8;
            // 
            // panelNamaMember
            // 
            this.panelNamaMember.BackColor = System.Drawing.SystemColors.Window;
            this.panelNamaMember.Controls.Add(this.textBoxNamaMember);
            this.panelNamaMember.Location = new System.Drawing.Point(130, 58);
            this.panelNamaMember.Name = "panelNamaMember";
            this.panelNamaMember.Padding = new System.Windows.Forms.Padding(3);
            this.panelNamaMember.Size = new System.Drawing.Size(240, 22);
            this.panelNamaMember.TabIndex = 30;
            // 
            // textBoxNamaMember
            // 
            this.textBoxNamaMember.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNamaMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNamaMember.Location = new System.Drawing.Point(6, 5);
            this.textBoxNamaMember.Name = "textBoxNamaMember";
            this.textBoxNamaMember.Size = new System.Drawing.Size(228, 13);
            this.textBoxNamaMember.TabIndex = 7;
            // 
            // btnBatal
            // 
            this.btnBatal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBatal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBatal.Image = ((System.Drawing.Image)(resources.GetObject("btnBatal.Image")));
            this.btnBatal.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnBatal.Location = new System.Drawing.Point(111, 142);
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
            this.btnSimpan.Location = new System.Drawing.Point(16, 142);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(89, 35);
            this.btnSimpan.TabIndex = 28;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Diskon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nama Member";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tambah Data Member";
            // 
            // TambahMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 189);
            this.Controls.Add(this.panelDiskon);
            this.Controls.Add(this.panelNamaMember);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TambahMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TambahMember";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TambahMember_Paint);
            this.panelDiskon.ResumeLayout(false);
            this.panelDiskon.PerformLayout();
            this.panelNamaMember.ResumeLayout(false);
            this.panelNamaMember.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDiskon;
        private System.Windows.Forms.TextBox textBoxDiskon;
        private System.Windows.Forms.Panel panelNamaMember;
        private System.Windows.Forms.TextBox textBoxNamaMember;
        private DevExpress.XtraEditors.SimpleButton btnBatal;
        private DevExpress.XtraEditors.SimpleButton btnSimpan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}