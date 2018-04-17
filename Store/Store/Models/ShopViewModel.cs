using System.Collections.Generic;

namespace Store.Models
{
    public class ShopViewModel
    {
        public int ShopId { get; set; }
        public string ShopName { get; set; }
        public string Adress { get; set; }

        public virtual ICollection<ProductViewModel> Product { get; set; }
        public virtual ICollection<TimeTableViewModel> TimeTable { get; set; }
    }
}