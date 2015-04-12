using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.ModelView
{
    public class PelangganView
    {
        public int Id { get; set; }

        [DisplayName("Nama Pelanggan")]
        public string NamaPelanggan { get; set; }

        [DisplayName("Nomor KTP")]
        public String NomorKtp { get; set; }

        public string Alamat { get; set; }

        [DisplayName("Nomor Telepon")]
        public string NoTelepon { get; set; }

        [DisplayName("Jenis Member")]
        public string JenisMember { get; set; }
    }
}
