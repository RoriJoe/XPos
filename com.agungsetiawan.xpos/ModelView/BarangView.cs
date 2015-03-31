using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.ModelView
{
    public class BarangView
    {
        public int Id { get; set; }

        [DisplayName("Nama Barang")]
        public string NamaBarang { get; set; }

        [DisplayName("Harga Jual")]
        public decimal HargaJual { get; set; }

        [DisplayName("Harga Beli")]
        public decimal HargaBeli { get; set; }

        public int Stok { get; set; }

        public string Keterangan { get; set; }

        public string Kategori { get; set; }
        public string Supplier { get; set; }
    }
}
