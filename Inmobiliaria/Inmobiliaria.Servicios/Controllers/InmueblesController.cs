using Inmobiliaria.Datos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Inmobiliaria.Servicios.Controllers
{
    public class InmueblesController : ApiController
    {
        Inmobiliaria_DesarrolloEntities BD = new Inmobiliaria_DesarrolloEntities();

        [HttpGet]
        public IEnumerable<Inmuebles> Get()
        {    
            var LInmuebles = BD.Inmuebles.ToList();

            return LInmuebles;
        }

        [HttpGet]
        public Inmuebles Get(int id)
        {
            var Inmuebles = BD.Inmuebles.FirstOrDefault(x=> x.Id == id);

            return Inmuebles;
        }
    }
}
