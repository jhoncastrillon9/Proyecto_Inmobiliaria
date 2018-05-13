using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Inmobiliaria.Dominio;
using Newtonsoft.Json;
using System.Net.Http.Formatting;
using Inmobiliaria.Dominio.ViewModels;

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
            var request = clienteHttp.GetAsync("api/InmueblesViewModelApi/GetGeneral/").Result;

            //variables para el view
            ViewBag.ubicacion = "Inicio / Inmuebles / Listado";
            ViewBag.titulo = "Lista de Inmuebles!";
            ViewBag.icon = "home";

            //Si la respuesta es afirmativa (Devolvio algo)
            if (request.IsSuccessStatusCode)
            {
                //Leemos el resultado
                string resulstring = request.Content.ReadAsStringAsync().Result;

                var InmueblesViewModel = JsonConvert.DeserializeObject<InmueblesViewModelDTO>(resulstring);

                return View(InmueblesViewModel);
            }

            return View(new InmueblesViewModelDTO());

        }

        [HttpGet]
        public ActionResult Detalle_Inmueble(int Id)
        {
            //Indicamos donde tenemos las APi la Direccion
            clienteHttp.BaseAddress = new Uri("http://localhost:53650/");
            //Consumimos apis y guardamos resultados
            var request = clienteHttp.GetAsync("api/InmueblesViewModelApi/Getbyid/" + Id).Result;
            
            //variables para el view
            ViewBag.ubicacion = "Inicio / Inmuebles / Detalle de Inmueble";
            ViewBag.titulo = "Información del Inmueble";
            ViewBag.icon = "zoom_in";

            //si la consulta fue exitosa ...
            if (request.IsSuccessStatusCode)
            {
                string resulstring = request.Content.ReadAsStringAsync().Result;
                //Aca tenemos False o true de acuerdo a lo que halla pasado en el API Asi lo configuramos alla
                var InmueblesViewModel = JsonConvert.DeserializeObject<InmueblesViewModelDTO>(resulstring);
                return View(InmueblesViewModel);
            }
            return View(new InmueblesViewModelDTO());
        }

        [HttpGet]
        public ActionResult New_Inmuebles()
        {

            //Indicamos donde tenemos las APi la Direccion
            clienteHttp.BaseAddress = new Uri("http://localhost:53650/");
            //Consumimos apis y guardamos resultados
            var request = clienteHttp.GetAsync("api/InmueblesViewModelApi/GetNew/").Result;

            //variables para el view
            ViewBag.ubicacion = "Inicio / Inmuebles / Nuevo Inmueble";
            ViewBag.titulo = "Crear Inmueble";
            ViewBag.icon = "queue";

            //Si la respuesta es afirmativa (Devolvio algo)
            if (request.IsSuccessStatusCode)
            {
                //Leemos el resultado
                string resulstring = request.Content.ReadAsStringAsync().Result;

                var InmueblesViewModel = JsonConvert.DeserializeObject<InmueblesViewModelDTO>(resulstring);


                return View(InmueblesViewModel);
            }

            return View();
            //variables para el view

        }

        [HttpPost]
        public ActionResult New_Inmuebles(InmueblesViewModelDTO InmuebleNuevo)
        {
            try
            {
                InmuebleNuevo.Inmuebles.IdInmobiliaria = 1;
                //Indicamos donde tenemos las APi la Direccion
                clienteHttp.BaseAddress = new Uri("http://localhost:53650/");
                //Consumimos apis y guardamos resultados                
                var request = clienteHttp.PostAsync("api/InmueblesViewModelApi/PostNew/", InmuebleNuevo, new JsonMediaTypeFormatter()).Result;

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
            var request = clienteHttp.GetAsync("api/InmueblesViewModelApi/Getbyid/" + Id).Result;

            //si la consulta fue exitosa ...
            if (request.IsSuccessStatusCode)
            {
                string resulstring = request.Content.ReadAsStringAsync().Result;
                //Aca tenemos False o true de acuerdo a lo que halla pasado en el API Asi lo configuramos alla
                var InmueblesViewModel = JsonConvert.DeserializeObject<InmueblesViewModelDTO>(resulstring);
                return View(InmueblesViewModel);
            }
            return View(new InmueblesViewModelDTO());
        }

        [HttpPost]
        public ActionResult Editar_Inmuebles(InmueblesViewModelDTO InmuebleActualizar, int id)
        {
            InmuebleActualizar.Inmuebles.Id = id;
            try
            {
                //Indicamos donde tenemos las APi la Direccion
                clienteHttp.BaseAddress = new Uri("http://localhost:53650/");
                //Consumimos apis y guardamos resultados
                var request = clienteHttp.PutAsync("api/InmueblesViewModelApi/PutEdit/", InmuebleActualizar.Inmuebles, new JsonMediaTypeFormatter()).Result;

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
            var request = clienteHttp.DeleteAsync("api/InmueblesViewModelApi/DeleteItem/" + Id).Result;

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