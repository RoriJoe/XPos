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
        BarangRepository barangRepository;
        public PenjualanService()
        {
            penjualanRepository = new PenjualanRepository();
            barangRepository = new BarangRepository();
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
                var barang = barangRepository.Get(detail.BarangId);
                barang.Stok = barang.Stok - detail.Jumlah;
                barangRepository.Put(barang);
            }

            penjualanRepository.Post(penjualan);
        }
    }
}
