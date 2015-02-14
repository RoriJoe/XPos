using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace com.agungsetiawan.xpos.Model
{
    public class Pelanggan
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string NamaPelanggan { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string Alamat { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string NoTelepon { get; set; }

        public virtual Member Member { get; set; }
        public int MemberId { get; set; }
    }
}
