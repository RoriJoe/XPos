using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.ModelView
{
    public class PenjualanDetailView
    {
        public int Id { get; set; }
        public string Barang { get; set; }
        public string Ukuran { get; set; }
        public decimal Harga { get; set; }
        public int Jumlah { get; set; }
        public float Diskon { get; set; }
        public decimal SubTotal { get; set; }
        
    }
}
