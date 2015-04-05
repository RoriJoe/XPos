using com.agungsetiawan.xpos.Model;
using com.agungsetiawan.xpos.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.Service
{
    public class LaporanService
    {
        LaporanRepository laporanRepository;

        public LaporanService()
        {
            laporanRepository = new LaporanRepository();
        }

        public List<Laporan> GetLaporan()
        {
            return laporanRepository.GetLaporan();
        }

        public List<Laporan> GetLaporanKategori(int idKategori)
        {
            return laporanRepository.GetLaporanKategori(idKategori);
        }
    }
}
