using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Dominio
{
    public class RegistroIngresosDTO
    {
        public int Id { get; set; }
        public System.DateTime Fecha { get; set; }
        public int Tipo { get; set; }
        public decimal Valor { get; set; }
        public decimal Mora { get; set; }
        public decimal Descuento { get; set; }
        public decimal Iva { get; set; }
        public decimal Total { get; set; }
        public int IdCajaBanco { get; set; }
        public Nullable<int> IdCuentasxPagarContratos { get; set; }
        public Nullable<int> IdCuentasxCobrarContratos { get; set; }
        public string Nombre { get; set; }
        public int IdInmobiliaria { get; set; }
    }
}
