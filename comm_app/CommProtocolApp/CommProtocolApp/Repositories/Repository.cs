using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CommProtocolApp.Entity;

namespace CommProtocolApp.Repositories
{
    public class Repository<T> where T:class,new()
    {
        DBCONNEntities db = new DBCONNEntities();
  
        public List<T> GetAll()
        {
            return db.Set<T>().ToList();
        }
        public List<T> GetListById(Expression<Func<T, bool>> filter)
        {
            return db.Set<T>().Where(filter).ToList();
        }
        public void TAdd(T p)
        {   
            db.Set<T>().Add(p);
            db.SaveChanges();
        }
        public void TDelete(T p)
        {
            db.Set<T>().Remove(p);
            db.SaveChanges();
        }
        public T TGet(int id)
        {
            return db.Set<T>().Find(id);
        }
        public void TUpdate(T p)
        {
            db.SaveChanges();
        }   
        public T Find(Expression<Func<T,bool>>where)
        {
            return db.Set<T>().FirstOrDefault(where);
        } 

    }
}
