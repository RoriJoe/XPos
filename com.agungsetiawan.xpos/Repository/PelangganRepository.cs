using com.agungsetiawan.xpos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.Repository
{
    public class PelangganRepository : GenericRepository<Pelanggan>
    {
        public List<Pelanggan> FindyByNama(string nama)
        {
            var result = this.db.Pelanggans.Where(p => p.NamaPelanggan.ToLower().Contains(nama.ToLower())).ToList();
            return result;
        }
    }
}
