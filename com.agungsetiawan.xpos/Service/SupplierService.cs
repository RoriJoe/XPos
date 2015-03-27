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
    }
}
