using com.agungsetiawan.xpos.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.Repository
{
    public class LaporanRepository : GenericRepository<Laporan>
    {
        public List<Laporan> GetLaporan()
        {
            DbRawSqlQuery<Laporan> result = db.Database.SqlQuery<Laporan>
                                            ("SELECT p.tanggal, count(*) as 'Jumlah' from penjualans p group by date(p.tanggal)");
            List<Laporan> laporans = new List<Laporan>();
            
            foreach(var data in result)
            {
                laporans.Add(data);
            }

            return laporans;
        }
    }
}
