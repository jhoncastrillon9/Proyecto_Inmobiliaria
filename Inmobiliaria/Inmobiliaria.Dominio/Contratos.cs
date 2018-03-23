using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Dominio
{
    class Contratos
    {
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
    }
}
