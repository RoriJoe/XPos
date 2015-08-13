using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.Model
{
    public class Merek
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [DisplayName("Nama Merek")]
        public string NamaMerek { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Keterangan { get; set; }

        public List<Barang> Barangs { get; set; }
    }
}
