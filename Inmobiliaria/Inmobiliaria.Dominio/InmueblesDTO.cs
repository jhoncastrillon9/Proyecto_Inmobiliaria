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

        public int Id { get; set; } //ok
        public Nullable<int> Codigo { get; set; } //ok
        public string Titulo { get; set; } 
        public string Descripcion { get; set; }
        public string Direccion { get; set; } 
        public string Estado { get; set; } //ok
        public string Llaves { get; set; } //ok
        public decimal PrecioPropietario { get; set; } //ok
        public decimal Porcentaje { get; set; } //ok
        public Nullable<decimal> Honorarios { get; set; } //ok
        public Nullable<System.DateTime> FechaCaptacion { get; set; } //ok
        public Nullable<decimal> Iva { get; set; } //ok
        public decimal PrecioFinal { get; set; } //ok
        public Nullable<int> Habitaciones { get; set; } //ok
        public Nullable<int> Banos { get; set; } //ok
        public bool Porteria { get; set; } //ok
        public bool Piscina { get; set; } //ok
        public Nullable<decimal> Area { get; set; } //ok
        public int IdMunicipio { get; set; } //ok
        public int IdZonaMunicipio { get; set; } //ok
        public int IdPropietario { get; set; } //ok
        public string Observacion { get; set; } //ok
        public int IdCategoria { get; set; } //ok
        public int IdInmobiliaria { get; set; } //ok

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
