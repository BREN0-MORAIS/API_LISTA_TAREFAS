using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Repository
{
    public interface IRepository<T>
    {
        public void Add(T entity);
        public T Get(int? id);
        public void Remove(int? id);
        public IEnumerable<T> GetAll();
        public void Update(T entity);

    }
}
