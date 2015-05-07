using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com.agungsetiawan.xpos.View.VLaporan
{
    public partial class LaporanBukuBesar : Form
    {
        public LaporanBukuBesar()
        {
            InitializeComponent();
        }

        public void setDataReport(Report.BukuBesarReport bukuBesarReport)
        {
            crystalReportViewer.ReportSource = bukuBesarReport;
        }
    }
}
