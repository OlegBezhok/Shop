using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store.Models
{
    public class TimeTableViewModel
    {
        public int ShopId { get; set; }
        public string DayOfWeek { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int Id { get; set; }

        public virtual ShopViewModel Shops { get; set; }


    }
}