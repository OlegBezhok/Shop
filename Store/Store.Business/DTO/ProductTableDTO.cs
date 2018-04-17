using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Business.DTO
{
    public class ProductTableDTO
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Info { get; set; }
        
        public virtual ICollection<ShopsTableDTO> ShopsTable { get; set; }
    }
}
