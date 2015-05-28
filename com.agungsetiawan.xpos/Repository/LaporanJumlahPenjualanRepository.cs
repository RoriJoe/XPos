using com.agungsetiawan.xpos.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.Repository
{
    public class LaporanJumlahPenjualanRepository : GenericRepository<LaporanJumlahPenjualan>
    {
        public List<LaporanJumlahPenjualan> GetLaporan()
        {
            DbRawSqlQuery<LaporanJumlahPenjualan> result = db.Database.SqlQuery<LaporanJumlahPenjualan>
                                            ("SELECT p.tanggal, count(*) as 'Jumlah' from penjualans p group by date(p.tanggal)");
            List<LaporanJumlahPenjualan> laporans = new List<LaporanJumlahPenjualan>();
            
            foreach(var data in result)
            {
                laporans.Add(data);
            }

            return laporans;
        }

        public List<LaporanJumlahPenjualan> GetLaporanKategori(int idKategori)
        {
            DbRawSqlQuery<LaporanJumlahPenjualan> result = db.Database.SqlQuery<LaporanJumlahPenjualan>
                                            ("SELECT p.tanggal,  sum(pd.Jumlah) as 'Jumlah' from penjualans p INNER JOIN penjualandetails pd ON (p.Id=pd.penjualanId) INNER JOIN barangs b ON (pd.BarangId=b.Id) group by date(p.tanggal),b.KategoriId HAVING b.KategoriId=" + idKategori);
            List<LaporanJumlahPenjualan> laporans = new List<LaporanJumlahPenjualan>();

            foreach (var data in result)
            {
                laporans.Add(data);
            }

            return laporans;
        }

        public List<LaporanJumlahPenjualan> GetLaporanBarang(int idBarang)
        {
            DbRawSqlQuery<LaporanJumlahPenjualan> result = db.Database.SqlQuery<LaporanJumlahPenjualan>
                                            ("SELECT p.tanggal,  sum(pd.Jumlah) as 'Jumlah' from penjualans p INNER JOIN penjualandetails pd ON (p.Id=pd.penjualanId) INNER JOIN barangs b ON (pd.BarangId=b.Id) group by date(p.tanggal),b.Id HAVING b.Id=" + idBarang);
            List<LaporanJumlahPenjualan> laporans = new List<LaporanJumlahPenjualan>();

            foreach (var data in result)
            {
                laporans.Add(data);
            }

            return laporans;
        }
    }
}
