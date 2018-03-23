using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Dominio
{
    class ZonasMunicipios
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdMunicipio { get; set; }
        public int IdInmobiliaria { get; set; }
    }
}
