using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DjSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Noticias()
        {
            return View();
        }

        public ActionResult test()
        {
            ViewBag.Nombre = "Cesar";
            lista de modelos
            return View("test",lista de modelos);
        }
    
    }
}