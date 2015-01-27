using com.agungsetiawan.xpos.Model;
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

namespace com.agungsetiawan.xpos.View.VKategori
{
    public partial class ListKategori : Form
    {
        static ListKategori form;
        KategoriService kategoriService;
        private ListKategori()
        {
            InitializeComponent();

            kategoriService = new KategoriService();

            var Kategoris = kategoriService.Get();
            dataGridViewKategori.DataSource = Kategoris;
        }

        public static ListKategori GetForm()
        {
            if(form==null || form.IsDisposed)
            {
                form = new ListKategori();
            }

            return form;
        }
    }
}
