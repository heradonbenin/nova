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
    
    public partial class PAYEMENT
    {
        public PAYEMENT()
        {
            this.FACTUREs = new HashSet<FACTURE>();
        }
    
        public int IdPay { get; set; }
        public Nullable<System.DateTime> DatePay { get; set; }
        public Nullable<short> ModePay { get; set; }
        public string CCPay { get; set; }
        public Nullable<int> MAPay { get; set; }
        public Nullable<int> MRPay { get; set; }
        public string AIPay { get; set; }
        public Nullable<short> ObjetPay { get; set; }
        public Nullable<int> IdBL { get; set; }
        public Nullable<int> IdU { get; set; }
        public Nullable<int> IdPayDRC { get; set; }
        public Nullable<int> IdClient { get; set; }
        public Nullable<int> IdPaySAP { get; set; }
        public string Caisse { get; set; }
        public string NumCheque { get; set; }
        public string RefVirement { get; set; }
        public string Banque { get; set; }
        public string Agence { get; set; }
        public string NumCompte { get; set; }
        public Nullable<int> IdBanque { get; set; }
        public string StatutPay { get; set; }
        public string RetIS { get; set; }
    
        public virtual ICollection<FACTURE> FACTUREs { get; set; }
    }
}