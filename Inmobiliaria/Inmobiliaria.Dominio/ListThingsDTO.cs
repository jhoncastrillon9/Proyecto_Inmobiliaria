using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Dominio
{
    using System;
    using System.Collections.Generic;

    public class ListThingsDTO
    {
        public int Id { get; set; }

        public string NAme { get; set; }

        public int IdTypeListThings { get; set; }



        public virtual TypeListThingsDTO TypeListThings { get; set; }
    }


    





    
}
