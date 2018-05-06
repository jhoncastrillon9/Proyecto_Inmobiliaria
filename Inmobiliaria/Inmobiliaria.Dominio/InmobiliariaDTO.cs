using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Dominio
{
    using System;
    using System.Collections.Generic;

    public class InmobiliariaDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InmobiliariaDTO()
        {
            this.Arrendatarios = new HashSet<ArrendatariosDTO>();
            this.CajaBanco = new HashSet<CajaBancoDTO>();
            this.CategoriaInmuebles = new HashSet<CategoriaInmueblesDTO>();
            this.Contratos = new HashSet<ContratosDTO>();
            this.CuentasxCobrarContratos = new HashSet<CuentasxCobrarContratosDTO>();
            this.CuentasxPagarContratos = new HashSet<CuentasxPagarContratosDTO>();
            this.Imagenes = new HashSet<ImagenesDTO>();
            this.Inmuebles = new HashSet<InmueblesDTO>();
            this.Municipios = new HashSet<MunicipiosDTO>();
            this.Propietarios = new HashSet<PropietariosDTO>();
            this.RegistroEgresos = new HashSet<RegistroEgresosDTO>();
            this.RegistroIngresos = new HashSet<RegistroIngresosDTO>();
            this.TipoPago = new HashSet<TipoPagoDTO>();
            this.Usuarios = new HashSet<UsuariosDTO>();
            this.ZonasMunicipios = new HashSet<ZonasMunicipiosDTO>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Documento { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Observacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArrendatariosDTO> Arrendatarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CajaBancoDTO> CajaBanco { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CategoriaInmueblesDTO> CategoriaInmuebles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContratosDTO> Contratos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CuentasxCobrarContratosDTO> CuentasxCobrarContratos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CuentasxPagarContratosDTO> CuentasxPagarContratos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImagenesDTO> Imagenes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InmueblesDTO> Inmuebles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MunicipiosDTO> Municipios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PropietariosDTO> Propietarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegistroEgresosDTO> RegistroEgresos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegistroIngresosDTO> RegistroIngresos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipoPagoDTO> TipoPago { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsuariosDTO> Usuarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZonasMunicipiosDTO> ZonasMunicipios { get; set; }
    }
}
