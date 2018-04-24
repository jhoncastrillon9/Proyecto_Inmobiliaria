using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Dominio
{
    using System;
    using System.Collections.Generic;

    public class EstadosCuentasDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EstadosCuentasDTO()
        {
            this.CuentasxCobrarContratos = new HashSet<CuentasxCobrarContratosDTO>();
            this.CuentasxPagarContratos = new HashSet<CuentasxPagarContratosDTO>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CuentasxCobrarContratosDTO> CuentasxCobrarContratos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CuentasxPagarContratosDTO> CuentasxPagarContratos { get; set; }
    }
}
