﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.9151
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.canadapost.ca/ws/pickup/availability")]
[System.Xml.Serialization.XmlRootAttribute("pickup-availability", Namespace="http://www.canadapost.ca/ws/pickup/availability", IsNullable=false)]
public partial class pickupavailability {
    
    private string postalcodeField;
    
    private string ondemandcutoffField;
    
    private boolean ondemandtourField;
    
    private string prorityworldcutoffField;
    
    private boolean scheduledpickupsavailableField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("postal-code")]
    public string postalcode {
        get {
            return this.postalcodeField;
        }
        set {
            this.postalcodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("on-demand-cutoff")]
    public string ondemandcutoff {
        get {
            return this.ondemandcutoffField;
        }
        set {
            this.ondemandcutoffField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("on-demand-tour")]
    public boolean ondemandtour {
        get {
            return this.ondemandtourField;
        }
        set {
            this.ondemandtourField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("prority-world-cutoff")]
    public string prorityworldcutoff {
        get {
            return this.prorityworldcutoffField;
        }
        set {
            this.prorityworldcutoffField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("scheduled-pickups-available")]
    public boolean scheduledpickupsavailable {
        get {
            return this.scheduledpickupsavailableField;
        }
        set {
            this.scheduledpickupsavailableField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.canadapost.ca/ws/pickup/availability")]
public enum boolean {
    
    /// <remarks/>
    @true,
    
    /// <remarks/>
    @false,
}
