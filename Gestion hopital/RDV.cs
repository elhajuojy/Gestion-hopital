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
    
    public partial class RDV
    {
        public int numeroRDV { get; set; }
        public Nullable<System.DateTime> dateRDV { get; set; }
        public string heureRDV { get; set; }
        public string codemedcin { get; set; }
        public string codepatient { get; set; }
    
        public virtual medecin medecin { get; set; }
        public virtual patient patient { get; set; }
    }
}