using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.Controllers
{
    public delegate String Bob();
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Mmmmm Donuts!";
            ViewBag.Message2 = "I like sprinkle donuts!";
            
            ViewBag.Message3 =(Bob) delegate() { return "DOOONUT"; };
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}