using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.Controllers
{

    public delegate String Bob();

    [RequireHttps]
    public class HomeController : Controller
    {
        private MusicStoreContext db = new MusicStoreContext();
        public ActionResult Index()
        {
            var genres = from genre in db.Genres select genre;
            return View(genres);
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

        public ActionResult Edit()
        {
            return View();
        }
    }
}