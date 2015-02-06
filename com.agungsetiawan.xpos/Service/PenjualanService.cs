using com.agungsetiawan.xpos.Model;
using com.agungsetiawan.xpos.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.Service
{
    public class PenjualanService
    {
        PenjualanRepository penjualanRepository;
        public PenjualanService()
        {
            penjualanRepository = new PenjualanRepository();
        }

        public String GetKodeTransaksiTerakhir()
        {
            var last=penjualanRepository.GetKodeTransaksiTerakhir();
            return last[0];
        }

        public void Post(Penjualan penjualan)
        {
            penjualanRepository.Post(penjualan);
        }
    }
}
