using com.agungsetiawan.xpos.Model;
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
        public ListKategori()
        {
            InitializeComponent();

            var Kategoris = new List<Kategori>()
            {
                new Kategori(){Id=1,NamaKategori="Kategori 1",Keterangan="Keterangan"},
                new Kategori(){Id=2,NamaKategori="Kategori 2",Keterangan="Keterangan"},
                new Kategori(){Id=3,NamaKategori="Kategori 3",Keterangan="Keterangan"},
                new Kategori(){Id=4,NamaKategori="Kategori 4",Keterangan="Keterangan"},
                new Kategori(){Id=5,NamaKategori="Kategori 5",Keterangan="Keterangan"}
            };

            dataGridViewKategori.DataSource = Kategoris;
        }
    }
}
