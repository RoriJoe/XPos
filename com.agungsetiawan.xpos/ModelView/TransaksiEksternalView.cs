using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.ModelView
{
    public class TransaksiEksternalView : TransaksiInternalView
    {
        public int Id { get; set; }

        public string Tanggal { get; set; }

        public string Keterangan { get; set; }
        public string Jumlah { get; set; }

        public string Jenis { get; set; }
    }
}
