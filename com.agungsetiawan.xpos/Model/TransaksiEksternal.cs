using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.Model
{
    public class TransaksiEksternal
    {
        public int Id { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime Tanggal { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Keterangan { get; set; }
        public decimal Jumlah { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Jenis { get; set; }
    }
}
