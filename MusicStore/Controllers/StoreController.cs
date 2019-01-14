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

        public String Browse()
        {
            return "Hello from Store.Browse()";
        }

        public String Details()
        {
            return "Hello from Store.Details()";
        }
    }
}