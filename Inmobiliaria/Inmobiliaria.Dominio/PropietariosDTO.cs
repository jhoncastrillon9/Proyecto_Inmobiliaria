using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Dominio
{
    using System;
    using System.Collections.Generic;

    public class PropietariosDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PropietariosDTO()
        {
            this.Inmuebles = new HashSet<InmueblesDTO>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Documento { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Observacion { get; set; }
        public int IdInmobiliaria { get; set; }

        public virtual InmobiliariaDTO Inmobiliaria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InmueblesDTO> Inmuebles { get; set; }
    }
}
