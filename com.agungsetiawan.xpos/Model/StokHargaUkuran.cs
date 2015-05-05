using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.Model
{
    public class StokHargaUkuran
    {
        public int Id { get; set; }

        public string Ukuran { get; set; }

        public decimal HargaJual { get; set; }

        public decimal HargaBeli { get; set; }

        public int Stock { get; set; }

        public Barang Barang { get; set; }
        public int BarangId { get; set; }
    }
}
