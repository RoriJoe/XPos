using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.Model
{
    public class Barang
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(10)]
        public string KodeBarang { get; set; }

        [Column(TypeName="varchar")]
        [StringLength(50)]
        public string NamaBarang { get; set; }

        public decimal HargaJual { get; set; }

        public decimal HargaBeli { get; set; }

        public int Stok { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Keterangan { get; set; }

        public Kategori Kategori { get; set; }

        public int KategoriId { get; set; }

        public Supplier Supplier { get; set; }
        public int SupplierId { get; set; }

        public Merek Merek { get; set; }
        public int MerekId { get; set; }
    }
}
