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
    
    public partial class patient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public patient()
        {
            this.RDVs = new HashSet<RDV>();
        }
    
        public string codepatient { get; set; }
        public string nompatient { get; set; }
        public string adressepatient { get; set; }
        public Nullable<System.DateTime> datenaissance { get; set; }
        public string sexepatient { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RDV> RDVs { get; set; }
    }
}
