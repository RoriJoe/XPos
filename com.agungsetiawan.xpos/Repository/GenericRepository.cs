using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T:class
    {
        XPosContext db;
        DbSet<T> table;

        public GenericRepository()
        {
            db = new XPosContext();
            table = db.Set<T>();
        }

        public List<T> Get(int offset, int size)
        {
            return table.Skip(offset).Take(size).ToList();
        }

        public T Get(int id)
        {
            return table.Find(id);
        }

        public void Post(T entity)
        {
            table.Add(entity);
            db.SaveChanges();
        }

        public void Put(T entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(T entity)
        {
            table.Remove(entity);
            db.SaveChanges();
        }
    }
}
