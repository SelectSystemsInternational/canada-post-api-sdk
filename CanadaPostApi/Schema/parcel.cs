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
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.canadapost.ca/ws/shipment-v8")]
public partial class ParcelCharacteristicsType
{

    private decimal weightField;

    private ParcelCharacteristicsTypeDimensions dimensionsField;

    private bool unpackagedField;

    private bool unpackagedFieldSpecified;

    private bool mailingtubeField;

    private bool mailingtubeFieldSpecified;

    private bool oversizedField;

    private bool oversizedFieldSpecified;

    /// <remarks/>
    public decimal weight
    {
        get
        {
            return this.weightField;
        }
        set
        {
            this.weightField = value;
        }
    }

    /// <remarks/>
    public ParcelCharacteristicsTypeDimensions dimensions
    {
        get
        {
            return this.dimensionsField;
        }
        set
        {
            this.dimensionsField = value;
        }
    }

    /// <remarks/>
    public bool unpackaged
    {
        get
        {
            return this.unpackagedField;
        }
        set
        {
            this.unpackagedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool unpackagedSpecified
    {
        get
        {
            return this.unpackagedFieldSpecified;
        }
        set
        {
            this.unpackagedFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("mailing-tube")]
    public bool mailingtube
    {
        get
        {
            return this.mailingtubeField;
        }
        set
        {
            this.mailingtubeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool mailingtubeSpecified
    {
        get
        {
            return this.mailingtubeFieldSpecified;
        }
        set
        {
            this.mailingtubeFieldSpecified = value;
        }
    }

    /// <remarks/>
    public bool oversized
    {
        get
        {
            return this.oversizedField;
        }
        set
        {
            this.oversizedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool oversizedSpecified
    {
        get
        {
            return this.oversizedFieldSpecified;
        }
        set
        {
            this.oversizedFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.canadapost.ca/ws/shipment-v8")]
public partial class ParcelCharacteristicsTypeDimensions
{

    private decimal lengthField;

    private decimal widthField;

    private decimal heightField;

    /// <remarks/>
    public decimal length
    {
        get
        {
            return this.lengthField;
        }
        set
        {
            this.lengthField = value;
        }
    }

    /// <remarks/>
    public decimal width
    {
        get
        {
            return this.widthField;
        }
        set
        {
            this.widthField = value;
        }
    }

    /// <remarks/>
    public decimal height
    {
        get
        {
            return this.heightField;
        }
        set
        {
            this.heightField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.canadapost.ca/ws/authreturn-v2")]
public partial class AuthReturnParcelCharacteristicsType
{
    
    private decimal weightField;
    
    private bool weightFieldSpecified;
    
    private AuthReturnParcelCharacteristicsTypeDimensions dimensionsField;
    
    /// <remarks/>
    public decimal weight {
        get {
            return this.weightField;
        }
        set {
            this.weightField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool weightSpecified {
        get {
            return this.weightFieldSpecified;
        }
        set {
            this.weightFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public AuthReturnParcelCharacteristicsTypeDimensions dimensions {
        get {
            return this.dimensionsField;
        }
        set {
            this.dimensionsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.canadapost.ca/ws/authreturn-v2")]
public partial class AuthReturnParcelCharacteristicsTypeDimensions
{
    
    private decimal lengthField;
    
    private decimal widthField;
    
    private decimal heightField;
    
    /// <remarks/>
    public decimal length {
        get {
            return this.lengthField;
        }
        set {
            this.lengthField = value;
        }
    }
    
    /// <remarks/>
    public decimal width {
        get {
            return this.widthField;
        }
        set {
            this.widthField = value;
        }
    }
    
    /// <remarks/>
    public decimal height {
        get {
            return this.heightField;
        }
        set {
            this.heightField = value;
        }
    }
}