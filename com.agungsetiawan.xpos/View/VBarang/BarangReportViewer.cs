using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com.agungsetiawan.xpos.View.VBarang
{
    public partial class BarangReportViewer : Form
    {
        public BarangReportViewer()
        {
            InitializeComponent();
        }

        public void setDataReport(Report.BarangReport barangReport)
        {
            crystalReportViewerBarang.ReportSource = barangReport;
        }
    }
}
