//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InmobiliariaServicio.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TIPOPROPIEDAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPOPROPIEDAD()
        {
            this.PROPIEDADs = new HashSet<PROPIEDAD>();
        }
    
        public int ID { get; set; }
        public string NombreTipo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROPIEDAD> PROPIEDADs { get; set; }
    }
}
