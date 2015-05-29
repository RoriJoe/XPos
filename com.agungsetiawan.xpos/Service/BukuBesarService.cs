using com.agungsetiawan.xpos.Model;
using com.agungsetiawan.xpos.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.Service
{
    public class BukuBesarService
    {
        private BukuBesarRepository bukuBesarRepository;
        private PenjualanRepository penjualanRepository;
        private PembelianRepository pembelianRepository;
        private TransaksiInternalRepository transaksiInternalRepository;

        public BukuBesarService()
        {
            bukuBesarRepository=new BukuBesarRepository();
            penjualanRepository = new PenjualanRepository();
            pembelianRepository = new PembelianRepository();
            transaksiInternalRepository = new TransaksiInternalRepository();
        }

        public List<BukuBesar> GetByTanggal(DateTime tanggal)
        {
            var penjualans = penjualanRepository.FindByTanggal(tanggal);

            var bukuBesars = (from p in penjualans select new BukuBesar {
                                 Tanggal=p.Tanggal,
                                 Keterangan="Penjualan Pakaian",
                                 Debet=p.TotalHargaJual,
                                 Kredit=0
                            }).ToList();

            var pembelians=pembelianRepository.FindByTanggal(tanggal);
            var bukuBesarPembelian = (from p in pembelians
                                      select new BukuBesar
                                      {
                                          Tanggal = p.Tanggal,
                                          Keterangan = "Pembelian Pakaian",
                                          Debet = 0,
                                          Kredit = p.TotalHargaBeli
                                      }).ToList();

            bukuBesars.AddRange(bukuBesarPembelian);

            var transaksiInternals = transaksiInternalRepository.FindByTanggal(tanggal);

            BukuBesar bukuBesar;
            foreach(var t in transaksiInternals)
            {
                bukuBesar = new BukuBesar();

                bukuBesar.Tanggal = t.Tanggal;
                bukuBesar.Keterangan=t.Keterangan;

                if(t.Jenis.Equals("Debet"))
                {
                    bukuBesar.Debet = t.Jumlah;
                    bukuBesar.Kredit = 0;
                }
                else if(t.Jenis.Equals("Kredit"))
                {
                    bukuBesar.Debet = 0;
                    bukuBesar.Kredit = t.Jumlah;
                }

                bukuBesars.Add(bukuBesar);
            }

            var result = from b in bukuBesars orderby b.Tanggal select b;

            return result.ToList();
        }

        public List<BukuBesar> GetByTanggal(DateTime tanggalAwal, DateTime tanggalAkhir)
        {
            var penjualans = penjualanRepository.FindByTanggal(tanggalAwal, tanggalAkhir);
            
            var bukuBesars = (from p in penjualans
                              select new BukuBesar
                              {
                                  Tanggal = p.Tanggal,
                                  Keterangan = "Penjualan Pakaian",
                                  Debet = p.TotalHargaJual,
                                  Kredit = 0
                              }).ToList();

            var pembelians = pembelianRepository.FindByTanggal(tanggalAwal, tanggalAkhir);
            var bukuBesarPembelian = (from p in pembelians
                                      select new BukuBesar
                                      {
                                          Tanggal = p.Tanggal,
                                          Keterangan = "Pembelian Pakaian",
                                          Debet = 0,
                                          Kredit = p.TotalHargaBeli
                                      }).ToList();

            bukuBesars.AddRange(bukuBesarPembelian);

            var transaksiInternals = transaksiInternalRepository.FindByTanggal(tanggalAwal, tanggalAkhir);

            BukuBesar bukuBesar;
            foreach (var t in transaksiInternals)
            {
                bukuBesar = new BukuBesar();

                bukuBesar.Tanggal = t.Tanggal;
                bukuBesar.Keterangan = t.Keterangan;

                if (t.Jenis.Equals("Debet"))
                {
                    bukuBesar.Debet = t.Jumlah;
                    bukuBesar.Kredit = 0;
                }
                else if (t.Jenis.Equals("Kredit"))
                {
                    bukuBesar.Debet = 0;
                    bukuBesar.Kredit = t.Jumlah;
                }

                bukuBesars.Add(bukuBesar);
            }

            var result = from b in bukuBesars orderby b.Tanggal select b;

            return result.ToList();
        }

        public decimal GetTotalSaldoSebelumHariIni(DateTime tanggal)
        {
            decimal totalPenjualan = penjualanRepository.FindByTanggalSebelumHariIni(tanggal).Sum(p => p.TotalHargaJual);
            decimal totalPembelian = pembelianRepository.FindByTanggalSebelumHariIni(tanggal).Sum(p => p.TotalHargaBeli);

            var transaksiInternals = transaksiInternalRepository.FindByTanggalSebelumHariIni(tanggal);
            decimal debet=0, kredit=0, totalInternal=0;
            foreach (var t in transaksiInternals)
            {
                
                if (t.Jenis.Equals("Debet"))
                {
                    debet += t.Jumlah;
                }
                else if (t.Jenis.Equals("Kredit"))
                {
                    kredit += t.Jumlah;
                }
            }

            totalInternal = debet - kredit;

            decimal total = totalPenjualan - totalPembelian + totalInternal;
            return total;
        }

        public decimal GetTotalPemasukkanHariIni(DateTime tanggal)
        {
            decimal totalPenjualan = penjualanRepository.FindByTanggal(tanggal).Sum(p => p.TotalHargaJual);
            decimal totalPembelian = pembelianRepository.FindByTanggal(tanggal).Sum(p => p.TotalHargaBeli);

            var transaksiInternals = transaksiInternalRepository.FindByTanggal(tanggal);
            decimal debet = 0, kredit = 0, totalInternal = 0;
            foreach (var t in transaksiInternals)
            {

                if (t.Jenis.Equals("Debet"))
                {
                    debet += t.Jumlah;
                }
                else if (t.Jenis.Equals("Kredit"))
                {
                    kredit += t.Jumlah;
                }
            }

            totalInternal = debet - kredit;

            decimal total = totalPenjualan - totalPembelian + totalInternal;
            return total;
        }
    }
}
