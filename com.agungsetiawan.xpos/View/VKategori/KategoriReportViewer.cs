using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com.agungsetiawan.xpos.View.VKategori
{
    public partial class KategoriReportViewer : Form
    {
        public KategoriReportViewer()
        {
            InitializeComponent();
        }

        public void setDataReport(Report.KategoriReport kategoriReport)
        {
            crystalReportViewerKategori.ReportSource = kategoriReport;
        }
    }
}
