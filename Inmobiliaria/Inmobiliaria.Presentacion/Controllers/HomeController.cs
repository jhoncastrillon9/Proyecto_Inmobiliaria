using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inmobiliaria.Presentacion.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            //variables para el view
            ViewBag.ubicacion = "Inicio";
            ViewBag.titulo = "InmobiliariApp";
            ViewBag.icon = "lightbulb_outline";

            return View();
        }


    }
}