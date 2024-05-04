using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyMvcApp.Models;

namespace MyMvcApp.Controllers;

public class HomeController : Controller
{
        private static List<Order> orders = new List<Order>();

        public ActionResult Index()
        {
            return View(orders);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Order order)
        {
            order.OrderId = orders.Count + 1;
            orders.Add(order);
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }
}
