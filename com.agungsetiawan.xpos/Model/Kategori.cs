using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace com.agungsetiawan.xpos.Model
{
    public class Kategori
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string NamaKategori { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Keterangan { get; set; }

        public List<Barang> Barangs { get; set; }
    }
}
