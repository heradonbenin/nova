//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VSOM_API
{
    using System;
    using System.Collections.Generic;
    
    public partial class AVOIR
    {
        public AVOIR()
        {
            this.LIGNE_AVOIR = new HashSet<LIGNE_AVOIR>();
        }
    
        public int IdFA { get; set; }
        public Nullable<System.DateTime> DCFA { get; set; }
        public Nullable<System.DateTime> DVFA { get; set; }
        public string AIFA { get; set; }
        public string AIVFA { get; set; }
        public string StatutFA { get; set; }
        public Nullable<int> MHT { get; set; }
        public Nullable<int> MTVA { get; set; }
        public Nullable<int> MTTC { get; set; }
        public Nullable<int> IdBL { get; set; }
        public Nullable<int> IdArm { get; set; }
        public Nullable<int> IdU { get; set; }
        public Nullable<int> IdUV { get; set; }
        public Nullable<int> IdClient { get; set; }
        public Nullable<int> IdFD { get; set; }
        public Nullable<int> IdDocSAP { get; set; }
        public string ClientAvoir { get; set; }
        public string TypeAvoir { get; set; }
        public string TypeFacture { get; set; }
        public Nullable<int> IdPay { get; set; }
    
        public virtual ICollection<LIGNE_AVOIR> LIGNE_AVOIR { get; set; }
    }
}
