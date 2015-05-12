using com.agungsetiawan.xpos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.Repository
{
    public class PenjualanDetailRepository : GenericRepository<PenjualanDetail>
    {
        public List<PenjualanDetail> FindByPenjualanId(int id)
        {
            var result= (from pd in this.db.PenjualanDetails.Include("Barang") where pd.PenjualanId==id select pd).ToList();
            return result;
        }

        public List<PenjualanDetail> GetWithBarang(int[] ids)
        {
            var result = this.db.PenjualanDetails.Include("Barang").Where(pd=> ids.Contains(pd.PenjualanId)).ToList(); ;
            return result;
        }
    }
}
