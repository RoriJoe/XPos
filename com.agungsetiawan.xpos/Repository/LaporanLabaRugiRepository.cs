using com.agungsetiawan.xpos.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.Repository
{
    public class LaporanLabaRugiRepository : GenericRepository<LaporanLabaRugi>
    {
        public List<LaporanLabaRugi> GetLaporan()
        {
            DbRawSqlQuery<LaporanLabaRugi> result = db.Database.SqlQuery<LaporanLabaRugi>
                                            ("SELECT p.Tanggal, sum((pd.Harga-pd.HargaBeli)*pd.jumlah) as 'Jumlah' FROM penjualans p INNER JOIN penjualandetails pd ON p.Id=pd.PenjualanId GROUP BY date(p.Tanggal)");
            List<LaporanLabaRugi> laporans = new List<LaporanLabaRugi>();

            foreach (var data in result)
            {
                laporans.Add(data);
            }

            return laporans;
        }
    }
}
