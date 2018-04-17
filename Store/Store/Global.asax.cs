using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Ninject.Modules;
using Store.Business.Infastructure;
using Store.Util;
using Ninject;
using  Ninject.Web.Mvc;
using System.Web.Util;
namespace Store
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            App_Start.WebAutomapperConfig.Inicialize();

            NinjectModule storeServise = new StoreModule();
            NinjectModule serviseModule = new ServiceModule("DefaultConnection");
            var kernel = new StandardKernel(storeServise, serviseModule);
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
        }
    }
}
