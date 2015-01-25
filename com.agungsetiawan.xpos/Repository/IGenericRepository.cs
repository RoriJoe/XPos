using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.Repository
{
    interface IGenericRepository<T> where T:class
    {
        List<T> Get();
        T Get(int id);
        void Post(T entity);
        void Put(T entity);
        void Delete(T entity);
    }
}
