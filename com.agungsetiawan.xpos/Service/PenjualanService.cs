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
    public class PenjualanService
    {
        PenjualanRepository penjualanRepository;
        BarangRepository barangRepository;
        private StokHargaUkuranRepository shuRepository;
        public PenjualanService()
        {
            penjualanRepository = new PenjualanRepository();
            barangRepository = new BarangRepository();
            shuRepository = new StokHargaUkuranRepository();
        }

        public String GetKodeTransaksiTerakhir()
        {
            var last=penjualanRepository.GetKodeTransaksiTerakhir();

            if(last.Length==0)
            {
                return "";
            }

            return last[0];
        }

        public void Post(Penjualan penjualan)
        {
            var penjualanDetails = penjualan.PenjualanDetails;

            foreach(var detail in penjualanDetails)
            {
                var shu = shuRepository.FindByBarangIdAndUkuran(detail.BarangId, detail.Ukuran);
                shu.Stock = shu.Stock - detail.Jumlah;
                shuRepository.Put(shu);
            }

            penjualanRepository.Post(penjualan);
        }

        public List<PenjualanView> FindWithPelangganDanPengguna()
        {
            var result= penjualanRepository.FindWithPelangganDanPengguna();
            var penjualans = (from p in result select new PenjualanView {
                                Id=p.Id,
                                KodeTransaksi=p.KodeTransaksi,
                                Tanggal=p.Tanggal.ToString("dd MMMM yyyy HH:mm", CultureInfo.GetCultureInfo("id-ID")),
                                TotalHargaJual=p.TotalHargaJual,
                                Pengguna=p.Pengguna.Nama,
                                Pelanggan=p.Pelanggan.NamaPelanggan
                              }).ToList();
            return penjualans;
        }

        public List<PenjualanView> FindByKodeTransaksi(string kodeTransaksi)
        {
            var penjualans= penjualanRepository.FindByKodeTransaksi(kodeTransaksi);

            var result=(from p in penjualans select new PenjualanView()
                        {
                            Id = p.Id,
                            KodeTransaksi = p.KodeTransaksi,
                            Tanggal = p.Tanggal.ToString("dd MMMM yyyy HH:mm", CultureInfo.GetCultureInfo("id-ID")),
                            TotalHargaJual = p.TotalHargaJual,
                            Pengguna = p.Pengguna.Nama,
                            Pelanggan = p.Pelanggan.NamaPelanggan
                        }).ToList();

            return result;
        }

        public List<PenjualanView> FindByPelanggan(string namaPelanggan)
        {
            var penjualans = penjualanRepository.FindByPelanggan(namaPelanggan);

            var result = (from p in penjualans
                          select new PenjualanView()
                          {
                              Id = p.Id,
                              KodeTransaksi = p.KodeTransaksi,
                              Tanggal = p.Tanggal.ToString("dd MMMM yyyy HH:mm", CultureInfo.GetCultureInfo("id-ID")),
                              TotalHargaJual = p.TotalHargaJual,
                              Pengguna = p.Pengguna.Nama,
                              Pelanggan = p.Pelanggan.NamaPelanggan
                          }).ToList();

            return result;
        }

        public List<PenjualanView> FindByTanggal(DateTime tanggal)
        {
            var penjualans = penjualanRepository.FindByTanggal(tanggal);

            var result = (from p in penjualans
                          select new PenjualanView()
                          {
                              Id = p.Id,
                              KodeTransaksi = p.KodeTransaksi,
                              Tanggal = p.Tanggal.ToString("dd MMMM yyyy HH:mm", CultureInfo.GetCultureInfo("id-ID")),
                              TotalHargaJual = p.TotalHargaJual,
                              Pengguna = p.Pengguna.Nama,
                              Pelanggan = p.Pelanggan.NamaPelanggan
                          }).ToList();

            return result;
        }
    }
}
