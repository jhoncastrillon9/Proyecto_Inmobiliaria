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
    
    public partial class EstadosCuentas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EstadosCuentas()
        {
            this.CuentasxCobrarContratos = new HashSet<CuentasxCobrarContratos>();
            this.CuentasxPagarContratos = new HashSet<CuentasxPagarContratos>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CuentasxCobrarContratos> CuentasxCobrarContratos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CuentasxPagarContratos> CuentasxPagarContratos { get; set; }
    }
}
