using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RgAlumnosMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.MiTexto = "Brindamos los cursos que necesitas.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Contactanos = "Contactanos y te ayudaremos";

            return View();
        }
    }
}