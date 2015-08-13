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
        private TransaksiEksternalRepository transaksiEksternalRepository;

        public BukuBesarService()
        {
            bukuBesarRepository=new BukuBesarRepository();
            penjualanRepository = new PenjualanRepository();
            pembelianRepository = new PembelianRepository();
            transaksiInternalRepository = new TransaksiInternalRepository();
            transaksiEksternalRepository = new TransaksiEksternalRepository();
        }

        public List<BukuBesar> GetByTanggal(DateTime tanggal, bool IsBukuBesar)
        {
            var penjualans = penjualanRepository.FindByTanggal(tanggal);

            var bukuBesars = (from p in penjualans select new BukuBesar {
                                 Tanggal=p.Tanggal,
                                 Keterangan="Penjualan Pakaian",
                                 Debet=p.TotalHargaJual,
                                 Kredit=0
                            }).ToList();

            if (IsBukuBesar)
            {
                var pembelians = pembelianRepository.FindByTanggal(tanggal);
                var bukuBesarPembelian = (from p in pembelians
                                          select new BukuBesar
                                          {
                                              Tanggal = p.Tanggal,
                                              Keterangan = "Pembelian Pakaian",
                                              Debet = 0,
                                              Kredit = p.TotalHargaBeli
                                          }).ToList();

                bukuBesars.AddRange(bukuBesarPembelian);

                var transaksiEksternals = transaksiEksternalRepository.FindByTanggal(tanggal);

                BukuBesar bukuBesar;
                foreach (var t in transaksiEksternals)
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
            }

            if(!IsBukuBesar)
            {
                var transaksiInternals = transaksiInternalRepository.FindByTanggal(tanggal);

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

            var transaksiEksternals = transaksiEksternalRepository.FindByTanggal(tanggalAwal,tanggalAkhir);

            BukuBesar bukuBesar;
            foreach (var t in transaksiEksternals)
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

            //var transaksiInternals = transaksiInternalRepository.FindByTanggal(tanggalAwal, tanggalAkhir);

            //BukuBesar bukuBesar;
            //foreach (var t in transaksiInternals)
            //{
            //    bukuBesar = new BukuBesar();

            //    bukuBesar.Tanggal = t.Tanggal;
            //    bukuBesar.Keterangan = t.Keterangan;

            //    if (t.Jenis.Equals("Debet"))
            //    {
            //        bukuBesar.Debet = t.Jumlah;
            //        bukuBesar.Kredit = 0;
            //    }
            //    else if (t.Jenis.Equals("Kredit"))
            //    {
            //        bukuBesar.Debet = 0;
            //        bukuBesar.Kredit = t.Jumlah;
            //    }

            //    bukuBesars.Add(bukuBesar);
            //}

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

        public decimal GetTotalSaldoHariIni(DateTime tanggal)
        {
            //decimal totalPenjualan = penjualanRepository.FindByTanggalSampaiHariIni(tanggal.AddHours(23).AddMinutes(59)).Sum(p => p.TotalHargaJual);
            decimal totalPembelian = pembelianRepository.FindByTanggalSampaiHariIni(tanggal.AddHours(23).AddMinutes(59)).Sum(p => p.TotalHargaBeli);

            var transaksiInternals = transaksiInternalRepository.FindByTanggalSampaiHariIni(tanggal.AddHours(23).AddMinutes(59));
            decimal debetInternal = 0, kreditInternal = 0, totalInternal = 0;
            foreach (var t in transaksiInternals)
            {

                if (t.Jenis.Equals("Debet"))
                {
                    debetInternal += t.Jumlah;
                }
                else if (t.Jenis.Equals("Kredit"))
                {
                    kreditInternal += t.Jumlah;
                }
            }

            totalInternal = debetInternal - kreditInternal;


            var transaksiEksternal = transaksiEksternalRepository.FindByTanggalSampaiHariIni(tanggal.AddHours(23).AddMinutes(59));
            decimal debetEksternal = 0, kreditEKsternal = 0, totalEksternal = 0;
            foreach (var t in transaksiEksternal)
            {

                if (t.Jenis.Equals("Debet"))
                {
                    debetEksternal += t.Jumlah;
                }
                else if (t.Jenis.Equals("Kredit"))
                {
                    kreditEKsternal += t.Jumlah;
                }
            }

            totalEksternal = debetEksternal - kreditEKsternal;

            decimal total = /*(totalPenjualan - totalPembelian) + */(totalEksternal - totalInternal) - totalPembelian;
            return total;
        }

        public decimal GetTotalPemasukkanHariIni(DateTime tanggal)
        {
            decimal totalPenjualan = penjualanRepository.FindByTanggal(tanggal).Sum(p => p.TotalHargaJual);
            decimal totalPembelian = pembelianRepository.FindByTanggal(tanggal).Sum(p => p.TotalHargaBeli);

            //var transaksiInternals = transaksiInternalRepository.FindByTanggal(tanggal);
            //decimal debet = 0, kredit = 0, totalInternal = 0;
            //foreach (var t in transaksiInternals)
            //{

            //    if (t.Jenis.Equals("Debet"))
            //    {
            //        debet += t.Jumlah;
            //    }
            //    else if (t.Jenis.Equals("Kredit"))
            //    {
            //        kredit += t.Jumlah;
            //    }
            //}

            //totalInternal = debet - kredit;

            decimal total = totalPenjualan - totalPembelian;// +totalInternal;
            return total;
        }
    }
}
