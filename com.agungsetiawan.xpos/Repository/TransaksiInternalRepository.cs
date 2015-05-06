using com.agungsetiawan.xpos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.Repository
{
    public class TransaksiInternalRepository : GenericRepository<TransaksiInternal>
    {
        //public decimal GetLastTotal()
        //{
        //    return this.db.TransaksiInternals.OrderByDescending(t => t.Id).Select(t => t.Total)
        //               .Take(1).SingleOrDefault();
        //}
    }
}
