using com.agungsetiawan.xpos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.Repository
{
    public class PenggunaRepository : GenericRepository<Pengguna>
    {
        public Pengguna FindWithRole(int id)
        {
            var result = this.db.Penggunas.Include("Role").Where(p => p.Id.Equals(id)).SingleOrDefault();
            return result;
        }

        public List<Pengguna> FindWithRole()
        {
            var result = this.db.Penggunas.Include("Role").ToList();
            return result;
        }
    }
}
