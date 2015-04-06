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

        public List<Laporan> GetLaporanKategori(int idKategori)
        {
            DbRawSqlQuery<Laporan> result = db.Database.SqlQuery<Laporan>
                                            ("SELECT p.tanggal,  sum(pd.Jumlah) as 'Jumlah' from penjualans p INNER JOIN penjualandetails pd ON (p.Id=pd.penjualanId) INNER JOIN barangs b ON (pd.BarangId=b.Id) group by date(p.tanggal),b.KategoriId HAVING b.KategoriId=" + idKategori);
            List<Laporan> laporans = new List<Laporan>();

            foreach (var data in result)
            {
                laporans.Add(data);
            }

            return laporans;
        }
    }
}
