﻿namespace com.agungsetiawan.xpos.View.VPenjualan
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
            this.comboBoxCari = new System.Windows.Forms.ComboBox();
            this.textBoxCari = new System.Windows.Forms.TextBox();
            this.buttonCari = new System.Windows.Forms.Button();
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
            this.dataGridViewDaftarPenjualan.Location = new System.Drawing.Point(-3, 80);
            this.dataGridViewDaftarPenjualan.Name = "dataGridViewDaftarPenjualan";
            this.dataGridViewDaftarPenjualan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDaftarPenjualan.Size = new System.Drawing.Size(989, 240);
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
            this.dataGridViewDaftarPenjualanDetail.Location = new System.Drawing.Point(-3, 370);
            this.dataGridViewDaftarPenjualanDetail.Name = "dataGridViewDaftarPenjualanDetail";
            this.dataGridViewDaftarPenjualanDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDaftarPenjualanDetail.Size = new System.Drawing.Size(989, 137);
            this.dataGridViewDaftarPenjualanDetail.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.panel1.Location = new System.Drawing.Point(-3, 326);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 38);
            this.panel1.TabIndex = 3;
            // 
            // comboBoxCari
            // 
            this.comboBoxCari.FormattingEnabled = true;
            this.comboBoxCari.Location = new System.Drawing.Point(13, 24);
            this.comboBoxCari.Name = "comboBoxCari";
            this.comboBoxCari.Size = new System.Drawing.Size(159, 21);
            this.comboBoxCari.TabIndex = 4;
            // 
            // textBoxCari
            // 
            this.textBoxCari.Location = new System.Drawing.Point(202, 24);
            this.textBoxCari.Name = "textBoxCari";
            this.textBoxCari.Size = new System.Drawing.Size(166, 20);
            this.textBoxCari.TabIndex = 5;
            // 
            // buttonCari
            // 
            this.buttonCari.Location = new System.Drawing.Point(384, 20);
            this.buttonCari.Name = "buttonCari";
            this.buttonCari.Size = new System.Drawing.Size(75, 23);
            this.buttonCari.TabIndex = 6;
            this.buttonCari.Text = "Cari";
            this.buttonCari.UseVisualStyleBackColor = true;
            this.buttonCari.Click += new System.EventHandler(this.buttonCari_Click);
            // 
            // ListPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(983, 555);
            this.Controls.Add(this.buttonCari);
            this.Controls.Add(this.textBoxCari);
            this.Controls.Add(this.comboBoxCari);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewDaftarPenjualanDetail);
            this.Controls.Add(this.dataGridViewDaftarPenjualan);
            this.Name = "ListPenjualan";
            this.Text = "ListPenjualan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarPenjualan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarPenjualanDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDaftarPenjualan;
        private System.Windows.Forms.DataGridView dataGridViewDaftarPenjualanDetail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxCari;
        private System.Windows.Forms.TextBox textBoxCari;
        private System.Windows.Forms.Button buttonCari;
    }
}