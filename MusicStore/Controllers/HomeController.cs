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
        public ActionResult Special()
        {
            var album = GetSpecial();
            return PartialView("_Special", album);
        }
        // Select an album and discount it by 50%        
        private Album GetSpecial()
        {
            var album = db.Albums
                .OrderBy(a => System.Guid.NewGuid())
                .First();
            album.Price *= 0.5m;
            return album;
        }
        public ActionResult ArtistSearch(string q)
        {
            var artists = GetArtists(q);
            return PartialView(artists);
        }
        private List<Artist> GetArtists(string searchString)
        {
            return db.Artists.Where(a => a.Name.Contains(searchString)).ToList();
        }
        public ActionResult QuickSearch(string term)
        {
            var artists = GetArtists(term).Select(a => new { value = a.Name });
            return Json(artists, JsonRequestBehavior.AllowGet);
        }

    }
}