//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VesselStopOverDataEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class ARMATEUR
    {
        public ARMATEUR()
        {
            this.ESCALE = new HashSet<ESCALE>();
        }
    
        public int IdArm { get; set; }
        public string CodeArm { get; set; }
        public string NomArm { get; set; }
        public string StatutArm { get; set; }
        public string AIArm { get; set; }
        public string CCArm { get; set; }
        public string AdresseArm { get; set; }
    
        public virtual ICollection<ESCALE> ESCALE { get; set; }
    }
}
