using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Store.Data.Edmx;

namespace Store.Data.Repository
{
    public class Repository<T> : IRepository<T> where T :class
    {
        private readonly DbContext entities = null;
        private DbSet<T> _itemSet;

        public Repository(DbContext entities)
        {
            this.entities = entities;
            _itemSet = entities.Set<T>();
        }

        public void Create(T item)
        {
            _itemSet.Add(item);
        }

        public void Delete(T item)
        {
            _itemSet.Remove(item);
        }

        public void Update(T item)
        {
            _itemSet.AddOrUpdate(item);
        }

        public T Get(int id)
        {
            var temp = _itemSet.Find(id);
            var _itemSet2 = entities.Set<Products>();
            var t = _itemSet2.Select(x => x);
            return temp;
        }

        public IEnumerable<T> GetAll()
        {
            return _itemSet.AsEnumerable();
        }

        public T SingleOrDefault(Expression<Func<T, bool>> predicate)
        {
            return _itemSet.SingleOrDefault(predicate);
        }
    }
}
