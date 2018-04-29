using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Inmobiliaria.Dominio;
using Newtonsoft.Json;
using System.Net.Http.Formatting;



namespace Inmobiliaria.Presentacion.Controllers
{
    public class InmueblesController : Controller
    {
        //Instanciamos Para consumir Servicio
        HttpClient clienteHttp = new HttpClient();

        [HttpGet]
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

        [HttpGet]
        public ActionResult Detalle_Inmueble(int Id)
        {
            //Indicamos donde tenemos las APi la Direccion
            clienteHttp.BaseAddress = new Uri("http://localhost:53650/");
            //Consumimos apis y guardamos resultados
            var request = clienteHttp.GetAsync("api/InmueblesApi/" + Id).Result;

            //si la consulta fue exitosa ...
            if (request.IsSuccessStatusCode)
            {
                string resulstring = request.Content.ReadAsStringAsync().Result;
                //Aca tenemos False o true de acuerdo a lo que halla pasado en el API Asi lo configuramos alla
                var Inmueble = JsonConvert.DeserializeObject<InmueblesDTO>(resulstring);
                return View(Inmueble);
            }
            return View(new InmueblesDTO());
        }

        [HttpGet]
        public ActionResult New_Inmuebles()
        {
            //variables para el view
            ViewBag.ubicacion = "Inicio / Inmuebles / Nuevo Inmueble";
            ViewBag.titulo = "Crear Inmueble";
            ViewBag.icon = "queue";

            return View();

        }

        [HttpPost]
        public ActionResult New_Inmuebles(InmueblesDTO InmuebleNuevo)
        {
            try
            {
                InmuebleNuevo.IdInmobiliaria = 1;
                //Indicamos donde tenemos las APi la Direccion
                clienteHttp.BaseAddress = new Uri("http://localhost:53650/");
                //Consumimos apis y guardamos resultados
                var request = clienteHttp.PostAsync("api/InmueblesApi", InmuebleNuevo, new JsonMediaTypeFormatter()).Result;

                //si la consulta fue exitosa ...
                if (request.IsSuccessStatusCode)
                {
                    var resultString = request.Content.ReadAsStringAsync().Result;
                    //Aca tenemos False o true de acuerdo a lo que halla pasado en el API Asi lo configuramos alla
                    var inserto = JsonConvert.DeserializeObject<bool>(resultString);
                    //si se inserto el nuevo
                    if (inserto)
                    {
                        TempData["Msj"] = "El Inmueble fue guardado exitosamente";
                        TempData["TypeAlert"] = "success";
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        TempData["Msj"] = "El Inmueble no fue guardado, por favor verifique los campos";
                        TempData["TypeAlert"] = "danger";
                        return View(InmuebleNuevo);
                    }

                }
            }
            catch (Exception)
            {

                TempData["Msj"] = "Error: El Inmueble no fue guardado";
                TempData["TypeAlert"] = "danger";
                return View(InmuebleNuevo);
            }

            TempData["Msj"] = "El Inmueble no fue guardado";
            TempData["TypeAlert"] = "danger";
            return View(InmuebleNuevo);



        }


        [HttpGet]
        public ActionResult Editar_Inmuebles(int Id)
        {
            //Indicamos donde tenemos las APi la Direccion
            clienteHttp.BaseAddress = new Uri("http://localhost:53650/");
            //Consumimos apis y guardamos resultados
            var request = clienteHttp.GetAsync("api/InmueblesApi/" + Id).Result;

            //si la consulta fue exitosa ...
            if (request.IsSuccessStatusCode)
            {
                string resulstring = request.Content.ReadAsStringAsync().Result;
                //Aca tenemos False o true de acuerdo a lo que halla pasado en el API Asi lo configuramos alla
                var Inmueble = JsonConvert.DeserializeObject<InmueblesDTO>(resulstring);
                return View(Inmueble);
            }
            return View(new InmueblesDTO());
        }

        [HttpPost]
        public ActionResult Editar_Inmuebles(InmueblesDTO InmuebleActualizar)
        {
            try
            {
                //Indicamos donde tenemos las APi la Direccion
                clienteHttp.BaseAddress = new Uri("http://localhost:53650/");
                //Consumimos apis y guardamos resultados
                var request = clienteHttp.PutAsync("api/InmueblesApi", InmuebleActualizar, new JsonMediaTypeFormatter()).Result;

                //si la consulta fue exitosa ...
                if (request.IsSuccessStatusCode)
                {
                    var resultString = request.Content.ReadAsStringAsync().Result;
                    //Aca tenemos False o true de acuerdo a lo que halla pasado en el API Asi lo configuramos alla
                    var actualizado = JsonConvert.DeserializeObject<bool>(resultString);
                    //si se inserto el nuevo
                    if (actualizado)
                    {
                        TempData["Msj"] = "El Inmueble fue actualizado exitosamente";
                        TempData["TypeAlert"] = "success";
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        TempData["Msj"] = "El Inmueble no fue actualizado, por favor verifique los campos";
                        TempData["TypeAlert"] = "danger";
                        return View(InmuebleActualizar);
                    }

                }
            }
            catch (Exception)
            {

                TempData["Msj"] = "Error: El Inmueble no fue actualizado";
                TempData["TypeAlert"] = "danger";
                return View(InmuebleActualizar);
            }

            TempData["Msj"] = "El Inmueble no fue actualizado";
            TempData["TypeAlert"] = "danger";
            return View(InmuebleActualizar);
        }

        [HttpGet]
        public ActionResult Eliminar_Inmuebles(int Id)
        {
            //Indicamos donde tenemos las APi la Direccion
            clienteHttp.BaseAddress = new Uri("http://localhost:53650/");
            //Consumimos apis y guardamos resultados
            var request = clienteHttp.DeleteAsync("api/InmueblesApi/" + Id).Result;

            //si la consulta fue exitosa ...
            var resultString = request.Content.ReadAsStringAsync().Result;
            //Aca tenemos False o true de acuerdo a lo que halla pasado en el API Asi lo configuramos alla
            var Eliminado = JsonConvert.DeserializeObject<bool>(resultString);
            //si se inserto el nuevo
            if (Eliminado)
            {
                TempData["Msj"] = "El Inmueble fue Eliminado exitosamente";
                TempData["TypeAlert"] = "success";
                return RedirectToAction("Index");
            }
            TempData["Msj"] = "El Inmueble NO fue eliminado";
            TempData["TypeAlert"] = "danger";
            return RedirectToAction("Index");
        }

    }

}