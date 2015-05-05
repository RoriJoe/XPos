using com.agungsetiawan.xpos.Model;
using com.agungsetiawan.xpos.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.Service
{
    public class StokHargaUkuranService
    {
        private StokHargaUkuranRepository stokHargaUkuranRepository;

        public StokHargaUkuranService()
        {
            stokHargaUkuranRepository = new StokHargaUkuranRepository();
        }

        public List<StokHargaUkuran> FindByBarangId(int id)
        {
            return stokHargaUkuranRepository.FindByBarangId(id);
        }

        public void DeleteByBarangId(int id)
        {
            stokHargaUkuranRepository.DeleteByBarangId(id);
        }

        public decimal FindHargaByBrangIdAndUkuran(int barangId, string ukuran)
        {
            return stokHargaUkuranRepository.FindHargaByBarangIdAndUkuran(barangId, ukuran);
        }

        public StokHargaUkuran FindByBarangIdAndUkuran(int barangId, string ukuran)
        {
            return stokHargaUkuranRepository.FindByBarangIdAndUkuran(barangId, ukuran);
        }
    }
}
