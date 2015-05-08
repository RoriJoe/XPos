using com.agungsetiawan.xpos.Model;
using com.agungsetiawan.xpos.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.Service
{
    public class SupplierService
    {
        SupplierRepository supplierRepository;
        public SupplierService()
        {
            supplierRepository = new SupplierRepository();
        }

        public List<Supplier> Get()
        {
            return supplierRepository.Get();
        }

        public void Post(Supplier supplier)
        {
            supplierRepository.Post(supplier);
        }

        public void Put(Supplier supplier)
        {
            supplierRepository.Put(supplier);
        }

        public Supplier Get(int id)
        {
            return supplierRepository.Get(id);
        }

        public void Delete(Supplier supplier)
        {
            supplierRepository.Delete(supplier);
        }

        public List<Supplier> FindByNama(string nama)
        {
            return supplierRepository.FindByNama(nama);
        }
    }
}
