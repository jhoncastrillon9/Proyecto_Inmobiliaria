using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Dominio
{
    using System;
    using System.Collections.Generic;

    public class RolesUsuariosDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RolesUsuariosDTO()
        {
            this.Usuarios = new HashSet<UsuariosDTO>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsuariosDTO> Usuarios { get; set; }
    }
}
