//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gestion_hopital
{
    using System;
    using System.Collections.Generic;
    
    public partial class medecin
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public medecin()
        {
            this.RDVs = new HashSet<RDV>();
        }
    
        public string codemedcin { get; set; }
        public string nommedecin { get; set; }
        public string telmedecin { get; set; }
        public Nullable<System.DateTime> dateEmbauche { get; set; }
        public string specialitemedecin { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RDV> RDVs { get; set; }
    }
}
