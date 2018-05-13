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
    public class ZoneCitysController : Controller
    {
        HttpClient clienteHttp = new HttpClient();

        [HttpPost]
        public ActionResult GetFilterCity(int idCity)
        {
            //Indicamos donde tenemos las APi la Direccion
            clienteHttp.BaseAddress = new Uri("http://localhost:53650/");
            //Consumimos apis y guardamos resultados
            var request = clienteHttp.PostAsync("api/InmueblesViewModelApi/GetFilterCity/", idCity, new JsonMediaTypeFormatter()).Result;

            //Si la respuesta es afirmativa (Devolvio algo)
            if (request.IsSuccessStatusCode)
            {
                //Leemos el resultado
                string resulstring = request.Content.ReadAsStringAsync().Result;

                var ListZoneCity = JsonConvert.DeserializeObject<List<ZonasMunicipiosDTO>>(resulstring);

                return ListZoneCity;
            }

            return View(new InmueblesViewModelDTO());
          
        }


    }
}