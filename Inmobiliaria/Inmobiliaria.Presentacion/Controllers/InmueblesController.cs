using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Inmobiliaria.Dominio;
using Newtonsoft.Json;


namespace Inmobiliaria.Presentacion.Controllers
{
    public class InmueblesController : Controller
    {
        //Instanciamos Para consumir Servicio
        HttpClient clienteHttp = new HttpClient();

        // GET: Inmuebles
        public ActionResult Index()
        {
            //Indicamos donde tenemos las APi la Direccion

            clienteHttp.BaseAddress = new Uri("http://localhost:53650/");
            //Consumimos apis y guardamos resultados
            var request = clienteHttp.GetAsync("api/InmueblesApi").Result;

            //variables para el view
            ViewBag.ubicacion = "Inicio / Inmuebles / Listado";
            ViewBag.titulo = "Lista de Inmuebles!";
            ViewBag.icon = "home";

            //Si la respuesta es afirmativa (Devolvio algo)
            if (request.IsSuccessStatusCode)
            {
                //Leemos el resultado
                string resulstring = request.Content.ReadAsStringAsync().Result;

                var ListadoInmuebles = JsonConvert.DeserializeObject<List<InmueblesDTO>>(resulstring).ToList();


                return View(ListadoInmuebles);
            }

            return View(new List<InmueblesDTO>());

        }

        // GET: Inmuebles New
        public ActionResult New_Inmuebles()
        {
            //variables para el view
            ViewBag.ubicacion = "Inicio / Inmuebles / Nuevo Inmueble";
            ViewBag.titulo = "Crear Inmueble";
            ViewBag.icon = "queue";            

            return View();

        }
    }

}