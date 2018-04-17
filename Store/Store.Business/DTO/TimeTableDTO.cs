using System.Collections.Generic;

namespace Store.Business.DTO
{
    public class TimeTableDTO
    {
        public int ShopId { get; set; }
        public string DayOfWeek { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int Id { get; set; }

        public virtual ShopsTableDTO Shops { get; set; }
    }
}