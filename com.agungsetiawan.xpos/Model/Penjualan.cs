using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.Model
{
    public class Penjualan
    {
        public int Id { get; set; }
        public DateTime Tanggal { get; set; }
        public DateTime Jam { get; set; }
        public decimal TotalHargaJual { get; set; }
        public Pelanggan Pelanggan { get; set; }
        public int PelangganId { get; set; }
        public Pengguna Pengguna { get; set; }
        public int PenggunaId { get; set; }

        public List<PenjualanDetail> PenjualanDetails { get; set; }
    }
}
