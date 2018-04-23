using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Dominio
{
    using System;
    using System.Collections.Generic;

    public class ContratosDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContratosDTO()
        {
            this.CuentasxCobrarContratos = new HashSet<CuentasxCobrarContratosDTO>();
            this.CuentasxPagarContratos = new HashSet<CuentasxPagarContratosDTO>();
        }

        public int Id { get; set; }
        public System.DateTime FechaContrato { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public int CantidadMeses { get; set; }
        public decimal ValorMensual { get; set; }
        public string Observacion { get; set; }
        public Nullable<int> IdInmueble { get; set; }
        public int IdArrendatario { get; set; }
        public Nullable<int> IdCoArrendatario { get; set; }
        public Nullable<int> IdFiador1 { get; set; }
        public Nullable<int> IdFiador2 { get; set; }
        public int IdInmobiliaria { get; set; }

        public virtual ArrendatariosDTO Arrendatarios { get; set; }
        public virtual ArrendatariosDTO Arrendatarios1 { get; set; }
        public virtual ArrendatariosDTO Arrendatarios2 { get; set; }
        public virtual ArrendatariosDTO Arrendatarios3 { get; set; }
        public virtual InmueblesDTO Inmuebles { get; set; }
        public virtual InmobiliariaDTO Inmobiliaria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CuentasxCobrarContratosDTO> CuentasxCobrarContratos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CuentasxPagarContratosDTO> CuentasxPagarContratos { get; set; }
    }
}
