namespace com.agungsetiawan.xpos.View.VBarang
{
    partial class BarangReportViewer
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
            this.crystalReportViewerBarang = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerBarang
            // 
            this.crystalReportViewerBarang.ActiveViewIndex = -1;
            this.crystalReportViewerBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerBarang.CachedPageNumberPerDoc = 10;
            this.crystalReportViewerBarang.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerBarang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerBarang.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerBarang.Name = "crystalReportViewerBarang";
            this.crystalReportViewerBarang.Size = new System.Drawing.Size(672, 376);
            this.crystalReportViewerBarang.TabIndex = 0;
            this.crystalReportViewerBarang.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // BarangReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 376);
            this.Controls.Add(this.crystalReportViewerBarang);
            this.Name = "BarangReportViewer";
            this.Text = "BarangReportViewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerBarang;
    }
}