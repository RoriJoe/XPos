using com.agungsetiawan.xpos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.Repository
{
    public class PembelianDetailRepository : GenericRepository<PembelianDetail>
    {
        public List<PembelianDetail> FindByPembelianId(int id)
        {
            var result = (from pd in this.db.PembelianDetails.Include("Barang") where pd.PembelianId == id select pd).ToList();
            return result;
        }
    }
}
