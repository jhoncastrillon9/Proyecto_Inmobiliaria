using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Dominio
{
    public class CuentasxPagarContratosDTO
    {
        public int Id { get; set; }
        public int Numerocuota { get; set; }
        public decimal Valor { get; set; }
        public System.DateTime FechaVencimiento { get; set; }
        public Nullable<int> IdEstado { get; set; }
        public int IdContrato { get; set; }
        public int IdInmobiliaria { get; set; }
    }
}
