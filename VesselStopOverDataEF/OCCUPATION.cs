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
    
    public partial class OCCUPATION
    {
        public int IdOccup { get; set; }
        public Nullable<System.DateTime> DateDebut { get; set; }
        public Nullable<System.DateTime> DateFin { get; set; }
        public Nullable<int> IdVeh { get; set; }
        public Nullable<int> IdEmpl { get; set; }
        public Nullable<int> IdTypeOp { get; set; }
        public Nullable<int> IdCtr { get; set; }
    
        public virtual EMPLACEMENT EMPLACEMENT { get; set; }
        public virtual TYPE_OPERATION TYPE_OPERATION { get; set; }
        public virtual VEHICULE VEHICULE { get; set; }
    }
}
