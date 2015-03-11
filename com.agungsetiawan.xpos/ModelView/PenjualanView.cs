using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.ModelView
{
    public class PenjualanView
    {
        public int Id { get; set; }

        [DisplayName("Kode Transaksi")]
        public string KodeTransaksi { get; set; }

        public string Tanggal { get; set; }

        [DisplayName("Total Harga Jual")]
        public decimal TotalHargaJual { get; set; }
        public string Pelanggan { get; set; }

        public string Pengguna { get; set; }


    }
}
