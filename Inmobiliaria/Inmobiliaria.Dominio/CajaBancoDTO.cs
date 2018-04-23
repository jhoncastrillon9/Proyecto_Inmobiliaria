using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Dominio
{
    using System;
    using System.Collections.Generic;

    public class CajaBancoDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CajaBancoDTO()
        {
            this.RegistroEgresos = new HashSet<RegistroEgresosDTO>();
            this.RegistroIngresos = new HashSet<RegistroIngresosDTO>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdInmobiliaria { get; set; }

        public virtual InmobiliariaDTO Inmobiliaria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegistroEgresosDTO> RegistroEgresos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegistroIngresosDTO> RegistroIngresos { get; set; }
    }
}
