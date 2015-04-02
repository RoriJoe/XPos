using com.agungsetiawan.xpos.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com.agungsetiawan.xpos.View.VPengguna
{
    public partial class ListPengguna : Form
    {
        private PenggunaService penggunaService;
        private static ListPengguna form;
        private ListPengguna()
        {
            InitializeComponent();
            penggunaService = new PenggunaService();

            dataGridViewPengguna.DataSource = penggunaService.FindWithRole();
            dataGridViewPengguna.Columns[0].Visible = false;
        }

        public static ListPengguna GetForm()
        {
            if (form == null || form.IsDisposed)
                form = new ListPengguna();
            return form;
        }
    }
}
