using com.agungsetiawan.xpos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.Repository
{
    public class TransaksiEksternalRepository : GenericRepository<TransaksiEksternal>
    {
        public List<TransaksiEksternal> FindByTanggal(DateTime tanggal)
        {
            var result = (from t in db.TransaksiEksternals
                          where t.Tanggal.Year == tanggal.Year &&
                              t.Tanggal.Month == tanggal.Month &&
                              t.Tanggal.Day == tanggal.Day
                          orderby t.Tanggal descending
                          select t).ToList();
            return result;
        }

        public List<TransaksiEksternal> FindByTanggal(DateTime tanggalAwal, DateTime tanggalAkhir)
        {
            var result = (from t in db.TransaksiEksternals
                          where (t.Tanggal >= tanggalAwal && t.Tanggal <= tanggalAkhir)
                          orderby t.Tanggal descending
                          select t).ToList();
            return result;
        }

        public List<TransaksiEksternal> FindByTanggalSebelumHariIni(DateTime tanggal)
        {
            var result = (from t in db.TransaksiEksternals
                          where t.Tanggal < tanggal
                          orderby t.Tanggal descending
                          select t).ToList();
            return result;
        }

        public List<TransaksiEksternal> FindByTanggalSampaiHariIni(DateTime tanggal)
        {
            var result = (from t in db.TransaksiEksternals
                          where t.Tanggal <= tanggal
                          orderby t.Tanggal descending
                          select t).ToList();
            return result;
        }
    }
}
