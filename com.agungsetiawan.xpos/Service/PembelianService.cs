using com.agungsetiawan.xpos.Model;
using com.agungsetiawan.xpos.ModelView;
using com.agungsetiawan.xpos.Repository;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.Service
{
    public class PembelianService
    {
        private PembelianRepository pembelianRepository;
        private BarangRepository barangRepository;
        private StokHargaUkuranRepository shuRepository;
        public PembelianService()
        {
            pembelianRepository = new PembelianRepository();
            barangRepository = new BarangRepository();
            shuRepository = new StokHargaUkuranRepository();
        }

        public String GetKodeTransaksiTerakhir()
        {
            var last = pembelianRepository.GetKodeTransaksiTerakhir();

            if (last.Length == 0)
            {
                return "";
            }

            return last[0];
        }

        public void Post(Pembelian pembelian)
        {
            var pembelianDetails = pembelian.PembelianDetails;

            foreach (var detail in pembelianDetails)
            {
                var shu = shuRepository.FindByBarangIdAndUkuran(detail.BarangId, detail.Ukuran);
                shu.Stock = shu.Stock + detail.Jumlah;
                shuRepository.Put(shu);
            }

            pembelianRepository.Post(pembelian);
        }

        public List<PembelianView> FindWithSupplierDanPengguna()
        {
            var result = pembelianRepository.FindWithSupplierDanPengguna();
            var pembelians = (from p in result
                              select new PembelianView
                              {
                                  Id = p.Id,
                                  KodeTransaksi = p.KodeTransaksi,
                                  Tanggal = p.Tanggal.ToString("dd MMMM yyyy HH:mm", CultureInfo.GetCultureInfo("id-ID")),
                                  TotalHargaBeli = p.TotalHargaBeli,
                                  Pengguna = p.Pengguna.Nama,
                                  Supplier = p.Supplier.NamaSupplier
                              }).ToList();
            return pembelians;
        }

        public List<PembelianView> FindByKodeTransaksi(string kodeTransaksi)
        {
            var penjualans = pembelianRepository.FindByKodeTransaksi(kodeTransaksi);

            var result = (from p in penjualans
                          select new PembelianView()
                          {
                              Id = p.Id,
                              KodeTransaksi = p.KodeTransaksi,
                              Tanggal = p.Tanggal.ToString("dd MMMM yyyy HH:mm", CultureInfo.GetCultureInfo("id-ID")),
                              TotalHargaBeli = p.TotalHargaBeli,
                              Pengguna = p.Pengguna.Nama,
                              Supplier = p.Supplier.NamaSupplier
                          }).ToList();

            return result;
        }

        public List<PembelianView> FindBySupplier(string namaSupplier)
        {
            var penjualans = pembelianRepository.FindBySupplier(namaSupplier);

            var result = (from p in penjualans
                          select new PembelianView()
                          {
                              Id = p.Id,
                              KodeTransaksi = p.KodeTransaksi,
                              Tanggal = p.Tanggal.ToString("dd MMMM yyyy HH:mm", CultureInfo.GetCultureInfo("id-ID")),
                              TotalHargaBeli = p.TotalHargaBeli,
                              Pengguna = p.Pengguna.Nama,
                              Supplier = p.Supplier.NamaSupplier
                          }).ToList();

            return result;
        }

        public List<PembelianView> FindByTanggal(DateTime tanggal)
        {
            var penjualans = pembelianRepository.FindByTanggal(tanggal);

            var result = (from p in penjualans
                          select new PembelianView()
                          {
                              Id = p.Id,
                              KodeTransaksi = p.KodeTransaksi,
                              Tanggal = p.Tanggal.ToString("dd MMMM yyyy HH:mm", CultureInfo.GetCultureInfo("id-ID")),
                              TotalHargaBeli = p.TotalHargaBeli,
                              Pengguna = p.Pengguna.Nama,
                              Supplier = p.Supplier.NamaSupplier
                          }).ToList();

            return result;
        }
    }
}
