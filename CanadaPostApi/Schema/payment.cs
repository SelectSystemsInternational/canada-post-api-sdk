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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.canadapost.ca/ws/ncshipment-v4")]
public enum CcType {
    
    /// <remarks/>
    MC,
    
    /// <remarks/>
    VIS,
    
    /// <remarks/>
    AME,
    
    /// <remarks/>
    DC,
    
    /// <remarks/>
    DIS,
    
    /// <remarks/>
    ER,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.canadapost.ca/ws/shipment-v8")]
public partial class SettlementInfoType
{

    private string paidbycustomerField;

    private string contractidField;

    private bool cifshipmentField;

    private bool cifshipmentFieldSpecified;

    private string intendedmethodofpaymentField;

    private string promocodeField;

    public SettlementInfoType()
    {
        this.cifshipmentField = true;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("paid-by-customer")]
    public string paidbycustomer
    {
        get
        {
            return this.paidbycustomerField;
        }
        set
        {
            this.paidbycustomerField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("contract-id")]
    public string contractid
    {
        get
        {
            return this.contractidField;
        }
        set
        {
            this.contractidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("cif-shipment")]
    public bool cifshipment
    {
        get
        {
            return this.cifshipmentField;
        }
        set
        {
            this.cifshipmentField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool cifshipmentSpecified
    {
        get
        {
            return this.cifshipmentFieldSpecified;
        }
        set
        {
            this.cifshipmentFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("intended-method-of-payment", DataType = "normalizedString")]
    public string intendedmethodofpayment
    {
        get
        {
            return this.intendedmethodofpaymentField;
        }
        set
        {
            this.intendedmethodofpaymentField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("promo-code", DataType = "normalizedString")]
    public string promocode
    {
        get
        {
            return this.promocodeField;
        }
        set
        {
            this.promocodeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.canadapost.ca/ws/shipment-v8")]
public partial class PreAuthorizedPaymentType
{

    private string accountnumberField;

    private string authcodeField;

    private System.DateTime authtimestampField;

    private decimal chargeamountField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("account-number", DataType = "normalizedString")]
    public string accountnumber
    {
        get
        {
            return this.accountnumberField;
        }
        set
        {
            this.accountnumberField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("auth-code", DataType = "normalizedString")]
    public string authcode
    {
        get
        {
            return this.authcodeField;
        }
        set
        {
            this.authcodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("auth-timestamp")]
    public System.DateTime authtimestamp
    {
        get
        {
            return this.authtimestampField;
        }
        set
        {
            this.authtimestampField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("charge-amount")]
    public decimal chargeamount
    {
        get
        {
            return this.chargeamountField;
        }
        set
        {
            this.chargeamountField = value;
        }
    }
}