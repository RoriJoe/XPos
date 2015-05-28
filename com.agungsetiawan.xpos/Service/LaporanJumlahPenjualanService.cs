using com.agungsetiawan.xpos.Model;
using com.agungsetiawan.xpos.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.Service
{
    public class LaporanJumlahPenjualanService
    {
        LaporanJumlahPenjualanRepository laporanRepository;

        public LaporanJumlahPenjualanService()
        {
            laporanRepository = new LaporanJumlahPenjualanRepository();
        }

        public List<LaporanJumlahPenjualan> GetLaporan()
        {
            return laporanRepository.GetLaporan();
        }

        public List<LaporanJumlahPenjualan> GetLaporanKategori(int idKategori)
        {
            return laporanRepository.GetLaporanKategori(idKategori);
        }
    }
}
