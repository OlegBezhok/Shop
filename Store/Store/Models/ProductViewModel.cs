using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store.Models
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Info { get; set; }

        public virtual ICollection<ShopViewModel> ShopsTable { get; set; }
    }
}