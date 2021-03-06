﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Dominio
{
    using System;
    using System.Collections.Generic;

    public class UsuariosDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        public string Estado { get; set; }
        public int Rol { get; set; }
        public Nullable<System.DateTime> FechaAdd { get; set; }
        public int IdInmobiliaria { get; set; }

        public virtual InmobiliariaDTO Inmobiliaria { get; set; }
        public virtual RolesUsuariosDTO RolesUsuarios { get; set; }
    }
}
