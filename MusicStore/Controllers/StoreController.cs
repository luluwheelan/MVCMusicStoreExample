using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.Controllers
{

    [RequireHttps]
    public class StoreController : Controller
    {
        private MusicStoreContext db = new MusicStoreContext();

        // GET: Store
        public String Index()
        {
            return "Hello from Store.Index()";
        }

        public ActionResult Browse(String Genre)
        {
            var albums = (from genre in db.Genres where genre.Name.Equals(Genre) select genre.Albums).SingleOrDefault();
            //if(albums == null) //goto an error page
            return View(albums);
        }

        public ActionResult Details(int id)
        {
            var album = (from a in db.Albums where a.AlbumId == id select a).SingleOrDefault();
            return View(album);
        }

        [Authorize]
        public ActionResult Buy(int id)
        {
            var album = (from a in db.Albums where a.AlbumId == id select a).SingleOrDefault();
            return View(album);
        }
    }
}