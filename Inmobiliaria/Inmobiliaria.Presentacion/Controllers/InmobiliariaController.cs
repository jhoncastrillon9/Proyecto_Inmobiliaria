using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inmobiliaria.Presentacion.Controllers
{
    public class InmobiliariaController : Controller
    {
        // GET: Inmobiliaria
        public ActionResult Index()
        {
            return View();
        }
    }
}