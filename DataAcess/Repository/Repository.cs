using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private   AppDataContext _db { get; set; }
        private   DbSet<T> _Dbset { get; set; }
        public Repository(AppDataContext db)
        {
            _db = db;
            _Dbset = db.Set<T>();
        }

        public void Add(T entity)
        {
            _Dbset.Add(entity);
            _db.SaveChanges();
        }

        public T Get(int? id)
        {
            return _Dbset.Find(id);
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> cond)
        {
            return _Dbset.Where(cond).ToList();
        }

        public IEnumerable<T> GetAll()
        {
            IEnumerable<T> db = _Dbset;

            return db.ToList();
        }

        public void Remove(int? id)
        {
           _Dbset.Remove(Get(id));
            _db.SaveChanges();
        }

        public void Update(T entity)
        {
            _Dbset.Update(entity);
            _db.SaveChanges();


        }
    }
}
