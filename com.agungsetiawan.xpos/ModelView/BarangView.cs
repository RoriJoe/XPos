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

        [DisplayName("Kode Barang")]
        public string KodeBarang { get; set; }

        [DisplayName("Nama Barang")]
        public string NamaBarang { get; set; }

        public string Merek { get; set; }

        public string Kategori { get; set; }

        public string Keterangan { get; set; }
        
        public string Supplier { get; set; }
        
    }
}
