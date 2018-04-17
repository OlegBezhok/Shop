
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Business.DTO;

namespace Store.Business.Interfaces
{
    public interface IStoreService
    {
        IEnumerable<ShopsTableDTO> GetAllShops();
        IEnumerable<ProductTableDTO> GetProductsByShop(int id);
    }
}
