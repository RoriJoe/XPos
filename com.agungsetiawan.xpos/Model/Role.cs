using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.Model
{
    public class Role
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public String NamaRole { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public String Keterangan { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(300)]
        public String Permissions { get; set; }
    }
}