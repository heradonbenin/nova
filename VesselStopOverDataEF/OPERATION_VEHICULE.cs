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
    
    public partial class OPERATION_VEHICULE
    {
        public int IdOpVeh { get; set; }
        public Nullable<int> IdVeh { get; set; }
        public Nullable<int> IdTypeOp { get; set; }
        public Nullable<System.DateTime> DateOp { get; set; }
        public string AIOp { get; set; }
        public Nullable<int> IdU { get; set; }
        public Nullable<int> IdLieu { get; set; }
    
        public virtual TYPE_OPERATION TYPE_OPERATION { get; set; }
        public virtual VEHICULE VEHICULE { get; set; }
    }
}
