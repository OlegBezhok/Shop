using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repository
{
    public interface IRepository<T> where T:class
    {
        void Create(T item);
        void Delete(T item);
        void Update(T item);
        T Get(int id);
        IEnumerable<T> GetAll();
        T SingleOrDefault(Expression<Func<T, bool>> predicate);
    }
}
