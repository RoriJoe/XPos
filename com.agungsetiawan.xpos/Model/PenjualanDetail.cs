using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.agungsetiawan.xpos.Model
{
    public class PenjualanDetail
    {
        public int Id { get; set; }
        public Penjualan Penjualan { get; set; }
        public int PenjualanId { get; set; }
        public Barang Barang { get; set; }
        public int BarangId { get; set; }
        public decimal Harga { get; set; }
        public int Jumlah { get; set; }
        public decimal SubTotal { get; set; }
        public float Diskon { get; set; }
    }
}
