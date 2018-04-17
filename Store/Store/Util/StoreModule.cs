using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject.Modules;
using Store.Business.Interfaces;
using Store.Business.Sevices;

namespace Store.Util
{
    public class StoreModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IStoreService>().To<StoreService>();
        }
    }
}