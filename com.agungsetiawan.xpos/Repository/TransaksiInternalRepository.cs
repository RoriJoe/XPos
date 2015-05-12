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

        public List<TransaksiInternal> FindByTanggal(DateTime tanggal)
        {
            var result = (from t in db.TransaksiInternals
                          where t.Tanggal.Year == tanggal.Year &&
                              t.Tanggal.Month == tanggal.Month &&
                              t.Tanggal.Day == tanggal.Day
                          orderby t.Tanggal descending
                          select t).ToList();
            return result;
        }

        public List<TransaksiInternal> FindByTanggal(DateTime tanggalAwal, DateTime tanggalAkhir)
        {
            var result = (from t in db.TransaksiInternals
                          where (t.Tanggal.Year >= tanggalAwal.Year && t.Tanggal.Year <= tanggalAkhir.Year) &&
                              (t.Tanggal.Month >= tanggalAwal.Month && t.Tanggal.Month <= tanggalAkhir.Month) &&
                              (t.Tanggal.Day >= tanggalAwal.Day && t.Tanggal.Day <= tanggalAwal.Day)
                          orderby t.Tanggal descending
                          select t).ToList();
            return result;
        }
    }
}
