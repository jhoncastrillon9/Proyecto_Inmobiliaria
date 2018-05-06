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
    
    public partial class Inmuebles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Inmuebles()
        {
            this.Contratos = new HashSet<Contratos>();
            this.Imagenes = new HashSet<Imagenes>();
        }
    
        public int Id { get; set; }
        public int IdEstado { get; set; }
        public Nullable<int> IdLlaves { get; set; }
        public Nullable<int> IdIva { get; set; }
        public string Codigo { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public decimal PrecioPropietario { get; set; }
        public Nullable<decimal> Porcentaje { get; set; }
        public Nullable<decimal> Honorarios { get; set; }
        public Nullable<System.DateTime> FechaCaptacion { get; set; }
        public decimal PrecioFinal { get; set; }
        public Nullable<int> Habitaciones { get; set; }
        public Nullable<int> Banos { get; set; }
        public bool Porteria { get; set; }
        public bool Piscina { get; set; }
        public Nullable<decimal> Area { get; set; }
        public int IdMunicipio { get; set; }
        public int IdZonaMunicipio { get; set; }
        public int IdPropietario { get; set; }
        public string Observacion { get; set; }
        public int IdCategoria { get; set; }
        public int IdInmobiliaria { get; set; }
    
        public virtual CategoriaInmuebles CategoriaInmuebles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contratos> Contratos { get; set; }
        public virtual Estados Estados { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Imagenes> Imagenes { get; set; }
        public virtual Inmobiliaria Inmobiliaria { get; set; }
        public virtual Iva Iva { get; set; }
        public virtual llaves llaves { get; set; }
        public virtual Municipios Municipios { get; set; }
        public virtual Propietarios Propietarios { get; set; }
        public virtual ZonasMunicipios ZonasMunicipios { get; set; }
    }
}
