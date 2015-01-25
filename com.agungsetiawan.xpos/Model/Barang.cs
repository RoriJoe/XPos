using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.Model
{
    public class Barang
    {
        public int Id { get; set; }
        public string NamaBarang { get; set; }
        public decimal HargaJual { get; set; }
        public decimal HargaBeli { get; set; }
        public int Stok { get; set; }
        public string Keterangan { get; set; }
        public Kategori Kategori { get; set; }
    }
}
