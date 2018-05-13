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

        [HttpPost]
        public List<ZonasMunicipios> GetFilterCity(int idCity)
        {
            var ZoneCitys = new List<ZonasMunicipios>();
            ZoneCitys = Database.ZonasMunicipios.Where(x => x.IdMunicipio == idCity).ToList();

            return ZoneCitys;
        }
    }
}
