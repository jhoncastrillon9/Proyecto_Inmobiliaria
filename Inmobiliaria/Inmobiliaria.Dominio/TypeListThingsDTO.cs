using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Dominio
{
    using System;
    using System.Collections.Generic;

    public class TypeListThingsDTO
    {
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
            public TypeListThingsDTO()
            {

                this.ListThings = new HashSet<ListThingsDTO>();

            }


            public int Id { get; set; }

            public string Name { get; set; }



            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

            public virtual ICollection<ListThingsDTO> ListThings { get; set; }

        
    }
}
