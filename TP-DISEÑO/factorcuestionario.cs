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
    
    public partial class factorcuestionario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public factorcuestionario()
        {
            this.preguntacuestionario = new HashSet<preguntacuestionario>();
        }
    
        public int IdFactorCuestionario { get; set; }
        public int ValorObtenido { get; set; }
        public string NombreFactor { get; set; }
        public int IdCompetenciaCuestionario { get; set; }
    
        public virtual competenciacuestionario competenciacuestionario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<preguntacuestionario> preguntacuestionario { get; set; }
    }
}
