using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public String Index()
        {
            return "Hello from Store.Index()";
        }

        public String Browse(String Genre)
        {
            return HttpUtility.HtmlEncode( "Hello from Store.Browse(): "+ Genre);
        }

        public String Details(int id)
        {
            return "Hello from Store.Details(), ID="+id;
        }
    }
}