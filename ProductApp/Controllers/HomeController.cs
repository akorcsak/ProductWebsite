using ProductApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductApp.Controllers
{
    public class HomeController : Controller
    {
        DB _db = new DB();

        public ActionResult Index()
        {
            var q = _db.Reviews.Where(r => r.CustomerName == "Vasile");

            return View(q.ToList());
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
    }
}