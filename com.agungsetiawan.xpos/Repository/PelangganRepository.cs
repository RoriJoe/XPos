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

        public List<Pelanggan> GetWithMember()
        {
            var result = this.db.Pelanggans.Include("Member").ToList();
            return result;
        }
        public List<Pelanggan> FindyByNama(string nama)
        {
            var result = this.db.Pelanggans.Include("Member").Where(p => p.NamaPelanggan.ToLower().Contains(nama.ToLower())).ToList();
            return result;
        }

        public Pelanggan FindDiskonNol()
        {
            var result = this.db.Pelanggans.Where(p => p.Member.Diskon == 0).SingleOrDefault();
            return result;
        }
    }
}
