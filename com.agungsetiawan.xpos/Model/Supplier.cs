using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.Model
{
    public class Supplier
    {
        public int Id { get; set; }
        public string NamaSupplier { get; set; }
        public string Alamat { get; set; }
        public string NoTelepon { get; set; }
        public List<Barang> Barangs { get; set; }
    }
}
