using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.agungsetiawan.xpos.Model
{
    public class Kategori
    {
        public int Id { get; set; }
        public string NamaKategori { get; set; }
        public string Keterangan { get; set; }
        public List<Barang> Barangs { get; set; }
    }
}
