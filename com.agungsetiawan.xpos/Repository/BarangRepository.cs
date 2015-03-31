using com.agungsetiawan.xpos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.Repository
{
    public class BarangRepository : GenericRepository<Barang>
    {
        public List<Barang> GetWithKategoriAndSupplier()
        {
            return db.Barangs.Include("Kategori").Include("Supplier").ToList();
        }

        public List<Barang> FindByNama(String nama)
        {
            return db.Barangs.Where(b => b.NamaBarang.ToLower().Contains(nama.ToLower())).ToList();
        }
    }
}
