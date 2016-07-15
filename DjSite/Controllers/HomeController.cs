using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DjSite.Models;
using Newtonsoft.Json;

namespace DjSite.Controllers
{
    public class HomeController : Controller
    {
        public static List<Musica> ListaMusic = new List<Musica>();
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Noticias(string codigo)
        {
            var noticia = new Noticia();
            if (codigo.Equals("1"))
            {
                noticia = new Noticia
                  {
                      id = Convert.ToInt32(codigo),
                      Nombre = "Enrique Iglesias",
                      Link = "http://"
                  };
            }
            if (codigo.Equals("2"))
            {
                noticia = new Noticia
                {
                    id = Convert.ToInt32(codigo),
                    Nombre = "Enrique Iglesias",
                    Link = "http://"
                };
            }
            return PartialView("Noticias", noticia);
        }

        public ActionResult test()
        {
            ViewBag.Titulo = "Ranking Musical";
            return View();
        }

        public ActionResult Musica()
        {
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

        public ActionResult Videos()
        {
            return View();
        }

        public ActionResult ArmarLista()
        {
            return View();
        }
        public void Enviar(string lista)
        {

            foreach (var song in lista.Split(';'))
            {
                if (!song.ToString().Equals(""))
                {
                    var nuevo = new Musica();
                    nuevo.Artista = song.Split('|')[0].ToString();
                    nuevo.Track = song.Split('|')[1].ToString();
                    ListaMusic.Add(nuevo);
                }


            }
        }
        [HttpPost]
        public ContentResult checkLogin(FormCollection myForm)
        {

            Dictionary<string, string> dt = new Dictionary<string, string>();

            Models.Users myUser = null;

            using (myUser = new Models.Users())
            {
                dt = myUser.checkLogin(myForm["usuario"], myForm["password"]);
            }

            //Creo variables de sesión
            if (dt["Status"] == "G")
            {
                Session["Activo"] = true;
                Session["Usuario"] = dt["Nombre"];
                Session["Mail"] = dt["Correo"];
            }

            string datos = JsonConvert.SerializeObject(dt, Formatting.Indented);
            return Content(datos, "application/json");
        }
        
    }
}

