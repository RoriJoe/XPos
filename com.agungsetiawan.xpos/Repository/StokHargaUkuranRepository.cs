using com.agungsetiawan.xpos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.Repository
{
    public class StokHargaUkuranRepository : GenericRepository<StokHargaUkuran>
    {
        public List<StokHargaUkuran> FindByBarangId(int id)
        {
            return this.db.StockHargaUkurans.Where(shu => shu.BarangId == id).ToList();
        }

        public void DeleteByBarangId(int id)
        {
            foreach(var x in FindByBarangId(id))
            {
                this.db.StockHargaUkurans.Remove(x);
            }

            this.db.SaveChanges();
        }

        public decimal FindHargaByBarangIdAndUkuran(int barangId, string ukuran)
        {
            return this.db.StockHargaUkurans.Where(s => s.BarangId == barangId && s.Ukuran.ToLower().Equals(ukuran.ToLower()))
                   .Select(d=>d.HargaJual).SingleOrDefault();
        }

        public StokHargaUkuran FindByBarangIdAndUkuran(int barangId, string ukuran)
        {
            return this.db.StockHargaUkurans.Where(s => s.BarangId == barangId && s.Ukuran.ToLower().Equals(ukuran.ToLower()))
                .SingleOrDefault();
        }
    }
}
