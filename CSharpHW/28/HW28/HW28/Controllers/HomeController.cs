using HW28.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace HW28.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            var order = await GetOrders();
            return View("Index", order);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        public Task<OrderModel> GetOrders()
        {
            var list = new List<OrderModel>()
            {
                new OrderModel("OnePlus5T", 13600),
                new OrderModel("Pixel", 27000),
                new OrderModel("IPhone6S", 18000),
                new OrderModel("IPhone10", 32000)
            };

            return Task.Factory.StartNew(() => list.SingleOrDefault(x => x.TotalPrice < 15000));
        }
    }
}