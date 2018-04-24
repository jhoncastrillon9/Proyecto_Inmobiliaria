using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Dominio
{
    using System;
    using System.Collections.Generic;

    public class InmueblesDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InmueblesDTO()
        {
            this.Contratos = new HashSet<ContratosDTO>();
            this.Imagenes = new HashSet<ImagenesDTO>();
        }

        public int Id { get; set; }
        public Nullable<int> Codigo { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public string Estado { get; set; }
        public string Llaves { get; set; }
        public decimal PrecioPropietario { get; set; }
        public decimal Porcentaje { get; set; }
        public Nullable<decimal> Honorarios { get; set; }
        public Nullable<System.DateTime> FechaCaptacion { get; set; }
        public Nullable<decimal> Iva { get; set; }
        public decimal PrecioFinal { get; set; }
        public Nullable<int> Habitaciones { get; set; }
        public Nullable<int> Banos { get; set; }
        public Nullable<bool> Porteria { get; set; }
        public Nullable<bool> Piscina { get; set; }
        public Nullable<decimal> Area { get; set; }
        public int IdMunicipio { get; set; }
        public int IdZonaMunicipio { get; set; }
        public int IdPropietario { get; set; }
        public string Observacion { get; set; }
        public int IdCategoria { get; set; }
        public int IdInmobiliaria { get; set; }

        public virtual CategoriaInmueblesDTO CategoriaInmuebles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContratosDTO> Contratos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImagenesDTO> Imagenes { get; set; }
        public virtual InmobiliariaDTO Inmobiliaria { get; set; }
        public virtual MunicipiosDTO Municipios { get; set; }
        public virtual PropietariosDTO Propietarios { get; set; }
        public virtual ZonasMunicipios ZonasMunicipios { get; set; }



    }
}
