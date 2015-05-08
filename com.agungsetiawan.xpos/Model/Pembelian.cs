using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.Model
{
    public class Pembelian
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string KodeTransaksi { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime Tanggal { get; set; }

        public decimal TotalHargaBeli { get; set; }
        public Supplier Supplier { get; set; }
        public int SupplierId { get; set; }
        public Pengguna Pengguna { get; set; }
        public int PenggunaId { get; set; }

        public List<PembelianDetail> PembelianDetails { get; set; }

        public Pembelian()
        {
            PembelianDetails = new List<PembelianDetail>();
        }
    }
}
