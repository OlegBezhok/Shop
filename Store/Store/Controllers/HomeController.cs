using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Store.Business.DTO;
using Store.Business.Interfaces;
using Store.Business.Sevices;
using Store.Models;

namespace Store.Controllers
{
    public class HomeController : Controller
    {
        private IStoreService _storeService;

        public HomeController(IStoreService storeService)
        {
            this._storeService = storeService;
        }

        public ActionResult Index()
        {
            var shops = Mapper.Map<IEnumerable<ShopsTableDTO>, IEnumerable<ShopViewModel>>(_storeService.GetAllShops());
            return View(shops);
        }

        public ActionResult Products(int shop_id)
        {
            var products =
                Mapper.Map<IEnumerable<ProductTableDTO>, IEnumerable<ProductViewModel>>(
                    _storeService.GetProductsByShop(shop_id));
            return View(products);
        }
    }
}