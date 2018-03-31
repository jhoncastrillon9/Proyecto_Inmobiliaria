using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inmobiliaria.Presentacion.Controllers
{
    public class PropietariosController : Controller
    {
        // GET: Propietarios
        public ActionResult Nuevo_Propietarios()
        {
            return View();
        }


        // GET: Propietarios
        public ActionResult Listar_Propietarios()
        {
            return View();
        }
        public ActionResult Editar_Propietarios()
        {
            return View();
        }

    }
}