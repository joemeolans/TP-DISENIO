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
    
    public partial class pregunta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pregunta()
        {
            this.itemrespuestapregunta = new HashSet<itemrespuestapregunta>();
        }
    
        public int IdPregunta { get; set; }
        public string TextoPregunta { get; set; }
        public int NumeroOpcion { get; set; }
        public int IdFactor { get; set; }
    
        public virtual factor factor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<itemrespuestapregunta> itemrespuestapregunta { get; set; }
    }
}
