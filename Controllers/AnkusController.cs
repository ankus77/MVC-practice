using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebApp.Controllers
{
    public class AnkusController : Controller
    {
        // GET: Ankus
        public ActionResult Index()
        {
            var x = new ContentResult();
            x.Content = "ankusnayak";
            return x;

        }
        
    }
}