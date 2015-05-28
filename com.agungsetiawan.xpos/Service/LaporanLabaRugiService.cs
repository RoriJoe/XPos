using com.agungsetiawan.xpos.Model;
using com.agungsetiawan.xpos.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.Service
{
    public class LaporanLabaRugiService
    {
        LaporanLabaRugiRepository laporanLabaRugiRepository;

        public LaporanLabaRugiService()
        {
            laporanLabaRugiRepository = new LaporanLabaRugiRepository();
        }

        public List<LaporanLabaRugi> GetLaporan()
        {
            return laporanLabaRugiRepository.GetLaporan();
        }
    }
}
