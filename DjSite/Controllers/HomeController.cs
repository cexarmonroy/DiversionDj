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
            ViewBag.Nombre = "Cesar";
            return View();
        }

        public ActionResult test()
        {
            ViewBag.Nombre = "Cesar";
            return View();
        }

        public ActionResult Galeria()
        {
            return View();
        }

        public ActionResult Contacto()
        {
            return View();
        }
    
    }
}