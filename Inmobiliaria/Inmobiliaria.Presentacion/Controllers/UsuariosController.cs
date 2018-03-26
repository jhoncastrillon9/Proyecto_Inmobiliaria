using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inmobiliaria.Presentacion.Controllers
{
    public class UsuariosController : Controller
    {
        // GET: Usuarios
        public ActionResult Login()
        {            
            return View();
        }


        public ActionResult recuperarcontrasena()
        {
            return View();
        }

        public ActionResult registrarse()
        {
            return View();
        }


    }
}