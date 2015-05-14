using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.ModelView
{
    public class PembelianView
    {
        public int Id { get; set; }

        [DisplayName("Kode Transaksi")]
        public string KodeTransaksi { get; set; }

        public string Tanggal { get; set; }

        [DisplayName("Total Harga Beli")]
        public decimal TotalHargaBeli { get; set; }
        public string Supplier { get; set; }

        public string Pengguna { get; set; }
    }
}
