using com.agungsetiawan.xpos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.Repository
{
    public class PembelianRepository : GenericRepository<Pembelian>
    {
        public String[] GetKodeTransaksiTerakhir()
        {
            return this.db.Pembelians.OrderByDescending(x => x.Id).Select(p => p.KodeTransaksi).ToArray();
        }

        public List<Pembelian> FindWithSupplierDanPengguna()
        {
            var result = (from p in this.db.Pembelians.Include("Supplier").Include("Pengguna")
                          orderby p.Tanggal descending
                          select p).ToList();

            return result;
        }

        public List<Pembelian> FindByKodeTransaksi(string kodeTransaksi)
        {
            var result = (from p in db.Pembelians where p.KodeTransaksi.Equals(kodeTransaksi) select p).ToList();
            return result;
        }

        public List<Pembelian> FindBySupplier(string namaSupplier)
        {
            var result = (from p in db.Pembelians
                          where p.Supplier.NamaSupplier.ToLower().Contains(namaSupplier.ToLower())
                          orderby p.Tanggal descending
                          select p).ToList();
            return result;
        }

        public List<Pembelian> FindByTanggal(DateTime tanggal)
        {
            var result = (from p in db.Pembelians.Include("Pengguna").Include("Supplier")
                          where p.Tanggal.Year == tanggal.Year &&
                              p.Tanggal.Month == tanggal.Month &&
                              p.Tanggal.Day == tanggal.Day
                          orderby p.Tanggal descending
                          select p).ToList();
            return result;
        }

        public List<Pembelian> FindByTanggal(DateTime tanggalAwal, DateTime tanggalAkhir)
        {
            var result = (from p in db.Pembelians.Include("Pengguna").Include("Supplier")
                          where (p.Tanggal >= tanggalAwal && p.Tanggal <= tanggalAkhir) 
                          orderby p.Tanggal descending
                          select p).ToList();
            return result;
        }

        public List<Pembelian> FindByTanggalSebelumHariIni(DateTime tanggal)
        {
            var result = (from p in db.Pembelians.Include("Pengguna").Include("Supplier")
                          where p.Tanggal < tanggal
                          orderby p.Tanggal descending
                          select p).ToList();
            return result;
        }
    }
}
