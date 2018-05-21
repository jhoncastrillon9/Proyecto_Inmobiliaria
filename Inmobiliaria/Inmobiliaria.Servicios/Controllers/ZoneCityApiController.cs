using Inmobiliaria.Datos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Inmobiliaria.Servicios.Controllers
{
    public class ZoneCityApiController : ApiController
    {
        Inmobiliaria_DesarrolloEntities_Desarrollo Database = new Inmobiliaria_DesarrolloEntities_Desarrollo();

        [HttpGet]
        public IEnumerable<ZoneCitysView> GetFilterCity(int id)
        {
            
            var ZoneCitys = Database.ZoneCitysView.Where(x => x.IdMunicipio == id).ToList();

            return ZoneCitys;
        }
    }
}
