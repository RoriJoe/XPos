namespace com.agungsetiawan.xpos.View.VKategori
{
    partial class KategoriReportViewer
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
            this.crystalReportViewerKategori = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerKategori
            // 
            this.crystalReportViewerKategori.ActiveViewIndex = -1;
            this.crystalReportViewerKategori.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerKategori.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerKategori.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerKategori.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerKategori.Name = "crystalReportViewerKategori";
            this.crystalReportViewerKategori.Size = new System.Drawing.Size(642, 394);
            this.crystalReportViewerKategori.TabIndex = 0;
            this.crystalReportViewerKategori.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // KategoriReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 394);
            this.Controls.Add(this.crystalReportViewerKategori);
            this.Name = "KategoriReportViewer";
            this.Text = "KategoriReportViewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerKategori;
    }
}