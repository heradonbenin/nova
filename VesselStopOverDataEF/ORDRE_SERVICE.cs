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
    
    public partial class ORDRE_SERVICE
    {
        public ORDRE_SERVICE()
        {
            this.NOTE = new HashSet<NOTE>();
        }
    
        public int IdOS { get; set; }
        public Nullable<System.DateTime> DCrOS { get; set; }
        public Nullable<System.DateTime> DPExOS { get; set; }
        public Nullable<System.DateTime> DRExOS { get; set; }
        public Nullable<System.DateTime> DVOS { get; set; }
        public Nullable<System.DateTime> DClOS { get; set; }
        public string LibOS { get; set; }
        public string ObsOS { get; set; }
        public Nullable<int> IdFsseur { get; set; }
        public Nullable<int> IdEsc { get; set; }
        public Nullable<int> IdBL { get; set; }
        public Nullable<int> IdVeh { get; set; }
        public Nullable<int> IdCtr { get; set; }
        public Nullable<int> IdMafi { get; set; }
        public Nullable<int> IdGC { get; set; }
        public Nullable<int> IdPO { get; set; }
        public Nullable<int> IdPDN { get; set; }
        public Nullable<int> IdPINV { get; set; }
        public string StatutOS { get; set; }
    
        public virtual CONNAISSEMENT CONNAISSEMENT { get; set; }
        public virtual ESCALE ESCALE { get; set; }
        public virtual ICollection<NOTE> NOTE { get; set; }
    }
}
