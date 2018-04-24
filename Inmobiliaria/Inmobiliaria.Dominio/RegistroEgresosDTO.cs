using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Dominio
{
    using System;
    using System.Collections.Generic;

    public class RegistroEgresosDTO
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

        public virtual CajaBancoDTO CajaBanco { get; set; }
        public virtual CuentasxCobrarContratosDTO CuentasxCobrarContratos { get; set; }
        public virtual CuentasxPagarContratosDTO CuentasxPagarContratos { get; set; }
        public virtual InmobiliariaDTO Inmobiliaria { get; set; }
        public virtual TipoPagoDTO TipoPago { get; set; }
    }
}
