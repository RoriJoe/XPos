using com.agungsetiawan.xpos.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.Repository
{
    public class PenjualanRepository : GenericRepository<Penjualan>
    {
        public String[] GetKodeTransaksiTerakhir()
        {
            return this.db.Penjualans.OrderByDescending(x => x.Id).Select(p => p.KodeTransaksi).ToArray();
        }

        public List<Penjualan> FindWithPelangganDanPengguna()
        {
            var result = (from p in this.db.Penjualans.Include("Pelanggan").Include("Pengguna") orderby p.Tanggal descending
                          select p).ToList();
            
            return result;
        }

        public List<Penjualan> FindByKodeTransaksi(string kodeTransaksi)
        {
            var result = (from p in db.Penjualans where p.KodeTransaksi.Equals(kodeTransaksi) select p).ToList();
            return result;
        }

        public List<Penjualan> FindByPelanggan(string namaPelanggan)
        {
            var result = (from p in db.Penjualans where p.Pelanggan.NamaPelanggan.ToLower().Contains(namaPelanggan.ToLower())
                          orderby p.Tanggal descending select p).ToList();
            return result;
        }

        public List<Penjualan> FindByTanggal(DateTime tanggal)
        {
            var result = (from p in db.Penjualans.Include("Pelanggan").Include("Pengguna") where p.Tanggal.Year == tanggal.Year && 
                               p.Tanggal.Month==tanggal.Month && 
                               p.Tanggal.Day==tanggal.Day 
                          orderby p.Tanggal descending select p).ToList();
            return result;
        }

        public List<Penjualan> FindByTanggal(DateTime tanggalAwal, DateTime tanggalAkhir)
        {
            var result = (from p in db.Penjualans.Include("Pelanggan").Include("Pengguna")
                          where (p.Tanggal.Year >= tanggalAwal.Year && p.Tanggal.Year <= tanggalAkhir.Year) &&
                              (p.Tanggal.Month >= tanggalAwal.Month && p.Tanggal.Month <= tanggalAkhir.Month) &&
                              (p.Tanggal.Day >= tanggalAwal.Day && p.Tanggal.Day <= tanggalAkhir.Day)
                          orderby p.Tanggal descending
                          select p).ToList();
            return result;
        }
    }
}
