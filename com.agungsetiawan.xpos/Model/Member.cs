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
    public class Member
    {
        public int Id { get; set; }
        [DisplayName("Nama Member")]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string NamaMember { get; set; }
        public float Diskon { get; set; }
    }
}
