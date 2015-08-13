namespace com.agungsetiawan.xpos.View.VPembelian
{
    partial class ListPembelian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListPembelian));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewDaftarPembelianDetail = new System.Windows.Forms.DataGridView();
            this.dataGridViewDaftarPembelian = new System.Windows.Forms.DataGridView();
            this.comboBoxCari = new System.Windows.Forms.ComboBox();
            this.textBoxCari = new System.Windows.Forms.TextBox();
            this.panelComboCari = new System.Windows.Forms.Panel();
            this.panelCari = new System.Windows.Forms.Panel();
            this.buttonRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.buttonCari = new DevExpress.XtraEditors.SimpleButton();
            this.dateTimePickerCari = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarPembelianDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarPembelian)).BeginInit();
            this.panelComboCari.SuspendLayout();
            this.panelCari.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.panel1.Location = new System.Drawing.Point(-1, 306);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 38);
            this.panel1.TabIndex = 15;
            // 
            // dataGridViewDaftarPembelianDetail
            // 
            this.dataGridViewDaftarPembelianDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDaftarPembelianDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewDaftarPembelianDetail.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewDaftarPembelianDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDaftarPembelianDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaftarPembelianDetail.Location = new System.Drawing.Point(-1, 350);
            this.dataGridViewDaftarPembelianDetail.Name = "dataGridViewDaftarPembelianDetail";
            this.dataGridViewDaftarPembelianDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDaftarPembelianDetail.Size = new System.Drawing.Size(989, 193);
            this.dataGridViewDaftarPembelianDetail.TabIndex = 14;
            this.dataGridViewDaftarPembelianDetail.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewDaftarPembelianDetail_RowPostPaint);
            // 
            // dataGridViewDaftarPembelian
            // 
            this.dataGridViewDaftarPembelian.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDaftarPembelian.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewDaftarPembelian.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewDaftarPembelian.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDaftarPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaftarPembelian.Location = new System.Drawing.Point(-1, 99);
            this.dataGridViewDaftarPembelian.Name = "dataGridViewDaftarPembelian";
            this.dataGridViewDaftarPembelian.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDaftarPembelian.Size = new System.Drawing.Size(989, 201);
            this.dataGridViewDaftarPembelian.TabIndex = 13;
            this.dataGridViewDaftarPembelian.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewDaftarPembelian_RowPostPaint);
            this.dataGridViewDaftarPembelian.SelectionChanged += new System.EventHandler(this.dataGridViewDaftarPembelian_SelectionChanged);
            // 
            // comboBoxCari
            // 
            this.comboBoxCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCari.FormattingEnabled = true;
            this.comboBoxCari.Location = new System.Drawing.Point(0, 1);
            this.comboBoxCari.Name = "comboBoxCari";
            this.comboBoxCari.Size = new System.Drawing.Size(169, 21);
            this.comboBoxCari.TabIndex = 4;
            this.comboBoxCari.SelectedValueChanged += new System.EventHandler(this.comboBoxCari_SelectedValueChanged);
            // 
            // textBoxCari
            // 
            this.textBoxCari.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCari.Location = new System.Drawing.Point(3, 6);
            this.textBoxCari.Name = "textBoxCari";
            this.textBoxCari.Size = new System.Drawing.Size(217, 13);
            this.textBoxCari.TabIndex = 5;
            // 
            // panelComboCari
            // 
            this.panelComboCari.Controls.Add(this.comboBoxCari);
            this.panelComboCari.Location = new System.Drawing.Point(42, 15);
            this.panelComboCari.Name = "panelComboCari";
            this.panelComboCari.Size = new System.Drawing.Size(169, 23);
            this.panelComboCari.TabIndex = 20;
            // 
            // panelCari
            // 
            this.panelCari.BackColor = System.Drawing.SystemColors.Window;
            this.panelCari.Controls.Add(this.textBoxCari);
            this.panelCari.Location = new System.Drawing.Point(239, 15);
            this.panelCari.Name = "panelCari";
            this.panelCari.Size = new System.Drawing.Size(223, 23);
            this.panelCari.TabIndex = 19;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.Image")));
            this.buttonRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.buttonRefresh.Location = new System.Drawing.Point(284, 50);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(84, 32);
            this.buttonRefresh.TabIndex = 18;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonCari
            // 
            this.buttonCari.Image = ((System.Drawing.Image)(resources.GetObject("buttonCari.Image")));
            this.buttonCari.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.buttonCari.Location = new System.Drawing.Point(374, 50);
            this.buttonCari.Name = "buttonCari";
            this.buttonCari.Size = new System.Drawing.Size(88, 32);
            this.buttonCari.TabIndex = 17;
            this.buttonCari.Text = "Cari";
            this.buttonCari.Click += new System.EventHandler(this.buttonCari_Click);
            // 
            // dateTimePickerCari
            // 
            this.dateTimePickerCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateTimePickerCari.Location = new System.Drawing.Point(478, 16);
            this.dateTimePickerCari.Name = "dateTimePickerCari";
            this.dateTimePickerCari.Size = new System.Drawing.Size(217, 20);
            this.dateTimePickerCari.TabIndex = 16;
            this.dateTimePickerCari.Visible = false;
            // 
            // ListPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 558);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewDaftarPembelianDetail);
            this.Controls.Add(this.dataGridViewDaftarPembelian);
            this.Controls.Add(this.panelComboCari);
            this.Controls.Add(this.panelCari);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonCari);
            this.Controls.Add(this.dateTimePickerCari);
            this.Name = "ListPembelian";
            this.Text = "Daftar Pembelian";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ListPembelian_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarPembelianDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarPembelian)).EndInit();
            this.panelComboCari.ResumeLayout(false);
            this.panelCari.ResumeLayout(false);
            this.panelCari.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewDaftarPembelianDetail;
        private System.Windows.Forms.DataGridView dataGridViewDaftarPembelian;
        private System.Windows.Forms.ComboBox comboBoxCari;
        private System.Windows.Forms.TextBox textBoxCari;
        private System.Windows.Forms.Panel panelComboCari;
        private System.Windows.Forms.Panel panelCari;
        private DevExpress.XtraEditors.SimpleButton buttonRefresh;
        private DevExpress.XtraEditors.SimpleButton buttonCari;
        private System.Windows.Forms.DateTimePicker dateTimePickerCari;
    }
}