using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace com.agungsetiawan.xpos.Model
{
    public class Pengguna
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Username { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Nama { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Password { get; set; }
        public Role Role { get; set; }
        public int RoleId { get; set; }
    }
}
