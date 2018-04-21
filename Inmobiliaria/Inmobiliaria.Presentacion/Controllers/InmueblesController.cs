using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inmobiliaria.Presentacion.Controllers
{
    public class InmueblesController : Controller
    {
        // GET: Inmuebles
        // GET: Inmuebles
        public ActionResult Index()
        {

            ViewBag.ubicacion = "Inicio / Inmuebles / Listado";
            ViewBag.titulo = "Lista de Inmuebles!";
            ViewBag.icon = "home";

            return View();
        }
    }
}