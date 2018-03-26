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
    
    public partial class Contratos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contratos()
        {
            this.CuentasxCobrarContratos = new HashSet<CuentasxCobrarContratos>();
            this.CuentasxPagarContratos = new HashSet<CuentasxPagarContratos>();
        }
    
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
    
        public virtual Arrendatarios Arrendatarios { get; set; }
        public virtual Arrendatarios Arrendatarios1 { get; set; }
        public virtual Arrendatarios Arrendatarios2 { get; set; }
        public virtual Arrendatarios Arrendatarios3 { get; set; }
        public virtual Inmuebles Inmuebles { get; set; }
        public virtual Inmobiliaria Inmobiliaria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CuentasxCobrarContratos> CuentasxCobrarContratos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CuentasxPagarContratos> CuentasxPagarContratos { get; set; }
    }
}