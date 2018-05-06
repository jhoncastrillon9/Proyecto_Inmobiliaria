using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inmobiliaria.Datos.Modelo;

namespace Inmobiliaria.Datos.ViewModels
{
    public class InmueblesViewModel
    {
        public Inmuebles Inmuebles { get; set; }
        public List<Inmuebles> LInmuebles { get; set; }
        public List<Municipios> LMunicipios { get; set; }
        public List<Estados> Estados { get; set; }
        public List<ZonasMunicipios> LZonasMunicipios { get; set; }
        public List<llaves> Lllaves { get; set; }
        public List<Iva> Liva { get; set; }
        public List<Propietarios> LPropietarios { get; set; }
        public List<CategoriaInmuebles> LCategorias { get; set; }
    }
}
