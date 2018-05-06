using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Dominio.ViewModels
{
    public class InmueblesViewModelDTO
    {
        public InmueblesDTO Inmuebles { get; set; }
        public List<InmueblesDTO> LInmuebles { get; set; }
        public List<MunicipiosDTO> LMunicipios { get; set; }
        public List<EstadosDTO> Estados { get; set; }
        public List<ZonasMunicipiosDTO> LZonasMunicipios { get; set; }
        public List<llavesDTO> Lllaves { get; set; }
        public List<IvaDTO> Liva { get; set; }
        public List<PropietariosDTO> LPropietarios { get; set; }
        public List<CategoriaInmueblesDTO> LCategorias { get; set; }

    }
}
