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
        public ActionResult _Index_Tab_Inmuebles()
        {
            return View();
        }
        
        // GET: Inmuebles
        public ActionResult _CargarDetalle()
        {
            return View();
        }

        // GET: Inmuebles
        public ActionResult Listar_Inmuebles()
        {
            return View();
        }
    }
}