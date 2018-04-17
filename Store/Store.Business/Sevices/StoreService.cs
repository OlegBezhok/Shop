using System;
using System.Collections.Generic;
using AutoMapper;
using Ninject.Infrastructure.Language;
using Store.Business.DTO;
using Store.Business.Interfaces;
using Store.Data.Edmx;
using Store.Data.IUniteOfWork;

namespace Store.Business.Sevices
{
    public class StoreService : IStoreService
    {
        IUnitOfWork Database { get; set; }

        public StoreService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public IEnumerable<ShopsTableDTO> GetAllShops()
        { 
            return Mapper.Map<IEnumerable<Shops>, List<ShopsTableDTO>>(Database.Repository<Shops>().GetAll());
        }

        public IEnumerable<ProductTableDTO> GetProductsByShop(int id)
        {
            var temp = Database.Repository<Shops>().Get(id);
            var mapper = Mapper.Map<Shops, ShopsTableDTO>(temp);
            mapper.Product = Mapper.Map<IEnumerable<Products>, List<ProductTableDTO>>(temp.Products);
            return mapper.Product;
        }
    }
}