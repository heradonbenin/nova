﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :2.0.50727.6407
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=2.0.50727.3038.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/SchemaDouane.xsd")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/SchemaDouane.xsd", IsNullable=false)]
public partial class ExtractVeh {
    
    private ExtractVehVehicules[] vehiculesField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Vehicules")]
    public ExtractVehVehicules[] Vehicules {
        get {
            return this.vehiculesField;
        }
        set {
            this.vehiculesField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/SchemaDouane.xsd")]
public partial class ExtractVehVehicules {
    
    private string acconierField;
    
    private string nomNavField;
    
    private string numVoyField;
    
    private System.DateTime dateArrivField;
    
    private string numBLField;
    
    private string consigneeBLField;
    
    private string numChassisField;
    
    private string descriptionField;
    
    private System.DateTime dateEntreeParcField;
    
    /// <remarks/>
    public string Acconier {
        get {
            return this.acconierField;
        }
        set {
            this.acconierField = value;
        }
    }
    
    /// <remarks/>
    public string NomNav {
        get {
            return this.nomNavField;
        }
        set {
            this.nomNavField = value;
        }
    }
    
    /// <remarks/>
    public string NumVoySCR {
        get {
            return this.numVoyField;
        }
        set {
            this.numVoyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime DateArriv {
        get {
            return this.dateArrivField;
        }
        set {
            this.dateArrivField = value;
        }
    }
    
    /// <remarks/>
    public string NumBL {
        get {
            return this.numBLField;
        }
        set {
            this.numBLField = value;
        }
    }
    
    /// <remarks/>
    public string ConsigneeBL {
        get {
            return this.consigneeBLField;
        }
        set {
            this.consigneeBLField = value;
        }
    }
    
    /// <remarks/>
    public string NumChassis {
        get {
            return this.numChassisField;
        }
        set {
            this.numChassisField = value;
        }
    }
    
    /// <remarks/>
    public string Description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime DateEntreeParc {
        get {
            return this.dateEntreeParcField;
        }
        set {
            this.dateEntreeParcField = value;
        }
    }
}
