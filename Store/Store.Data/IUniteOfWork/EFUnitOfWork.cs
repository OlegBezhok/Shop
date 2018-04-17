using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Data.Edmx;
using Store.Data.Repository;

namespace Store.Data.IUniteOfWork
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly ShopDbEntities _entities = null;
        public Dictionary<Type,object> repositories = new Dictionary<Type, object>();

        public EFUnitOfWork(ShopDbEntities entities)
        {
            this._entities = entities;
        }

        public IRepository<T> Repository<T>() where T : class
        {
            if (repositories.Keys.Contains(typeof(T)))
            {
                return repositories[typeof(T)] as IRepository<T>;
            }
            IRepository<T> reposit = new Repository<T>(_entities);
            repositories.Add(typeof(T),reposit);
            return reposit;
        }

        public void SaveChanges()
        {
            _entities.SaveChanges();
        }
    }
}
