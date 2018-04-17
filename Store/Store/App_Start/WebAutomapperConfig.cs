using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Store.Business.Autommaper;
using Store.Business.DTO;
using Store.Models;

namespace Store.App_Start
{
    public class WebAutomapperConfig
    {
        public static void Inicialize()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<ShopsTableDTO, ShopViewModel>();
                cfg.CreateMap<ProductTableDTO, ProductViewModel>();
                cfg.CreateMap<TimeTableDTO, TimeTableViewModel>();
                cfg.AddProfile(new StoreMapper());
            });
        }
    }
}