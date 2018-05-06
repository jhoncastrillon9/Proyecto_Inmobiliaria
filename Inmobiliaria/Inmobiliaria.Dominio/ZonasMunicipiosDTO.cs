using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Dominio
{
    using System;
    using System.Collections.Generic;

    public class ZonasMunicipiosDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ZonasMunicipiosDTO()
        {
            this.Inmuebles = new HashSet<InmueblesDTO>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdMunicipio { get; set; }
        public int IdInmobiliaria { get; set; }

        public virtual InmobiliariaDTO Inmobiliaria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InmueblesDTO> Inmuebles { get; set; }
        public virtual MunicipiosDTO Municipios { get; set; }
    }
}
