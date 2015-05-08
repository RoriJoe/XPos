using com.agungsetiawan.xpos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.Repository
{
    public class SupplierRepository : GenericRepository<Supplier>
    {
        public List<Supplier> FindByNama(string nama)
        {
            var result = this.db.Suppliers.Where(p => p.NamaSupplier.ToLower().Contains(nama.ToLower())).ToList();
            return result;
        }
    }
}
