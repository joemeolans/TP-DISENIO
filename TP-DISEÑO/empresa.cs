//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TP_DISEÑO
{
    using System;
    using System.Collections.Generic;
    
    public partial class empresa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public empresa()
        {
            this.puestobuscado = new HashSet<puestobuscado>();
        }
    
        public int IdEmpresa { get; set; }
        public string NombreEmpresa { get; set; }
        public string DireccionEmpresa { get; set; }
        public int TelefonoEmpresa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<puestobuscado> puestobuscado { get; set; }
    }
}
