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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListPenjualan));
            this.dataGridViewDaftarPenjualan = new System.Windows.Forms.DataGridView();
            this.dataGridViewDaftarPenjualanDetail = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxCari = new System.Windows.Forms.ComboBox();
            this.textBoxCari = new System.Windows.Forms.TextBox();
            this.dateTimePickerCari = new System.Windows.Forms.DateTimePicker();
            this.buttonCari = new DevExpress.XtraEditors.SimpleButton();
            this.buttonRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.panelCari = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarPenjualan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarPenjualanDetail)).BeginInit();
            this.panelCari.SuspendLayout();
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
            this.dataGridViewDaftarPenjualan.Location = new System.Drawing.Point(-3, 108);
            this.dataGridViewDaftarPenjualan.Name = "dataGridViewDaftarPenjualan";
            this.dataGridViewDaftarPenjualan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDaftarPenjualan.Size = new System.Drawing.Size(989, 243);
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
            this.dataGridViewDaftarPenjualanDetail.Location = new System.Drawing.Point(-3, 401);
            this.dataGridViewDaftarPenjualanDetail.Name = "dataGridViewDaftarPenjualanDetail";
            this.dataGridViewDaftarPenjualanDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDaftarPenjualanDetail.Size = new System.Drawing.Size(989, 106);
            this.dataGridViewDaftarPenjualanDetail.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.panel1.Location = new System.Drawing.Point(-3, 357);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 38);
            this.panel1.TabIndex = 3;
            // 
            // comboBoxCari
            // 
            this.comboBoxCari.FormattingEnabled = true;
            this.comboBoxCari.Location = new System.Drawing.Point(47, 24);
            this.comboBoxCari.Name = "comboBoxCari";
            this.comboBoxCari.Size = new System.Drawing.Size(159, 21);
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
            // dateTimePickerCari
            // 
            this.dateTimePickerCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateTimePickerCari.Location = new System.Drawing.Point(476, 25);
            this.dateTimePickerCari.Name = "dateTimePickerCari";
            this.dateTimePickerCari.Size = new System.Drawing.Size(217, 20);
            this.dateTimePickerCari.TabIndex = 7;
            this.dateTimePickerCari.Visible = false;
            // 
            // buttonCari
            // 
            this.buttonCari.Image = ((System.Drawing.Image)(resources.GetObject("buttonCari.Image")));
            this.buttonCari.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.buttonCari.Location = new System.Drawing.Point(372, 59);
            this.buttonCari.Name = "buttonCari";
            this.buttonCari.Size = new System.Drawing.Size(88, 32);
            this.buttonCari.TabIndex = 9;
            this.buttonCari.Text = "Cari";
            this.buttonCari.Click += new System.EventHandler(this.buttonCari_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.Image")));
            this.buttonRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.buttonRefresh.Location = new System.Drawing.Point(282, 59);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(84, 32);
            this.buttonRefresh.TabIndex = 10;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // panelCari
            // 
            this.panelCari.BackColor = System.Drawing.SystemColors.Window;
            this.panelCari.Controls.Add(this.textBoxCari);
            this.panelCari.Location = new System.Drawing.Point(237, 24);
            this.panelCari.Name = "panelCari";
            this.panelCari.Size = new System.Drawing.Size(223, 23);
            this.panelCari.TabIndex = 11;
            // 
            // ListPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(983, 555);
            this.Controls.Add(this.panelCari);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonCari);
            this.Controls.Add(this.dateTimePickerCari);
            this.Controls.Add(this.comboBoxCari);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewDaftarPenjualanDetail);
            this.Controls.Add(this.dataGridViewDaftarPenjualan);
            this.Name = "ListPenjualan";
            this.Text = "ListPenjualan";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ListPenjualan_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarPenjualan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarPenjualanDetail)).EndInit();
            this.panelCari.ResumeLayout(false);
            this.panelCari.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDaftarPenjualan;
        private System.Windows.Forms.DataGridView dataGridViewDaftarPenjualanDetail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxCari;
        private System.Windows.Forms.TextBox textBoxCari;
        private System.Windows.Forms.DateTimePicker dateTimePickerCari;
        private DevExpress.XtraEditors.SimpleButton buttonCari;
        private DevExpress.XtraEditors.SimpleButton buttonRefresh;
        private System.Windows.Forms.Panel panelCari;
    }
}