using Inmobiliaria.Datos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Inmobiliaria.Servicios.Controllers
{
    public class CityApiController : ApiController
    {
        Inmobiliaria_DesarrolloEntities_Desarrollo Database = new Inmobiliaria_DesarrolloEntities_Desarrollo();

        [HttpGet]
        public List<Municipios> GetFilterCity(int id)
        {
            var Citys = new List<Municipios>();

            return Citys;
        }

    }
}
