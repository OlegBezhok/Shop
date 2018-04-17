using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Business.DTO
{
    public class ShopsTableDTO
    {
        public int ShopId { get; set; }
        public string ShopName { get; set; }
        public string Adress { get; set; }

        public virtual ICollection<ProductTableDTO> Product { get; set; }
        public virtual ICollection<TimeTableDTO> TimeTable { get; set; }
    }
}
