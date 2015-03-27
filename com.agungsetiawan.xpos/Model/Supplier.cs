using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.Model
{
    public class Supplier
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string NamaSupplier { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string Alamat { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string NoTelepon { get; set; }
        public List<Barang> Barangs { get; set; }
    }
}
