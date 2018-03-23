//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inmobiliaria.Datos.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class CuentasxPagarContratos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CuentasxPagarContratos()
        {
            this.RegistroEgresos = new HashSet<RegistroEgresos>();
            this.RegistroIngresos = new HashSet<RegistroIngresos>();
        }
    
        public int Id { get; set; }
        public int Numerocuota { get; set; }
        public decimal Valor { get; set; }
        public System.DateTime FechaVencimiento { get; set; }
        public Nullable<int> IdEstado { get; set; }
        public int IdContrato { get; set; }
        public int IdInmobiliaria { get; set; }
    
        public virtual Contratos Contratos { get; set; }
        public virtual EstadosCuentas EstadosCuentas { get; set; }
        public virtual Inmobiliaria Inmobiliaria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegistroEgresos> RegistroEgresos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegistroIngresos> RegistroIngresos { get; set; }
    }
}
