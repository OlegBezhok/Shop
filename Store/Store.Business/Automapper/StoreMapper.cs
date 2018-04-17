using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using System.Globalization;
using Store.Business.DTO;
using Store.Data.Edmx;

namespace Store.Business.Autommaper
{
    public class StoreMapper : Profile
    {
        public StoreMapper()
        {
            CreateMap<TimeTable, TimeTableDTO>();
            CreateMap<Shops, ShopsTableDTO>();
            CreateMap<Products, ProductTableDTO>();

        }
    }
}
