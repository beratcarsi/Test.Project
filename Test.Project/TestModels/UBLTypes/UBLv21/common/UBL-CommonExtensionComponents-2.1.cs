namespace EFatura.Core.UBLTypes.UBLv21.Ext
{
    using Udt;
    
    
    /// <summary>
    /// A single extension for private use.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    public partial class UBLExtensionType
    {
        
        /// <summary>
        /// An identifier for the Extension assigned by the creator of the extension.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType ID { get; set; }
        
        /// <summary>
        /// A name for the Extension assigned by the creator of the extension.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType Name { get; set; }
        
        /// <summary>
        /// An agency that maintains one or more Extensions.
        /// </summary>
        public ExtensionAgencyIDType ExtensionAgencyID { get; set; }
        
        /// <summary>
        /// The name of the agency that maintains the Extension.
        /// </summary>
        public ExtensionAgencyNameType ExtensionAgencyName { get; set; }
        
        /// <summary>
        /// The version of the Extension.
        /// </summary>
        public ExtensionVersionIDType ExtensionVersionID { get; set; }
        
        /// <summary>
        /// A URI for the Agency that maintains the Extension.
        /// </summary>
        public ExtensionAgencyURIType ExtensionAgencyURI { get; set; }
        
        /// <summary>
        /// A URI for the Extension.
        /// </summary>
        public ExtensionURIType ExtensionURI { get; set; }
        
        /// <summary>
        /// A code for reason the Extension is being included.
        /// </summary>
        public ExtensionReasonCodeType ExtensionReasonCode { get; set; }
        
        /// <summary>
        /// A description of the reason for the Extension.
        /// </summary>
        public ExtensionReasonType ExtensionReason { get; set; }
        
        /// <summary>
        /// The definition of the extension content.
        /// </summary>
       [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    public System.Xml.XmlElement ExtensionContent { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    public partial class ExtensionReasonType : TextType
    {
        
#if USE_IMPLICIT_ASSIGNMENT
        public static implicit operator ExtensionReasonType(System.String value)
        {
             return string.IsNullOrEmpty(value) ? null : new ExtensionReasonType { Value = value };
        }

        public static implicit operator System.String(ExtensionReasonType @this)
        {
             return @this.Value;
        }
#endif
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    public partial class ExtensionAgencyNameType : TextType
    {
        
#if USE_IMPLICIT_ASSIGNMENT
        public static implicit operator ExtensionAgencyNameType(System.String value)
        {
             return string.IsNullOrEmpty(value) ? null : new ExtensionAgencyNameType { Value = value };
        }

        public static implicit operator System.String(ExtensionAgencyNameType @this)
        {
             return @this.Value;
        }
#endif
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    public partial class ExtensionReasonCodeType : CodeType
    {
        
#if USE_IMPLICIT_ASSIGNMENT
        public static implicit operator ExtensionReasonCodeType(System.String value)
        {
             return string.IsNullOrEmpty(value) ? null : new ExtensionReasonCodeType { Value = value };
        }

        public static implicit operator System.String(ExtensionReasonCodeType @this)
        {
             return @this.Value;
        }
#endif
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    public partial class ExtensionVersionIDType : IdentifierType
    {
        
#if USE_IMPLICIT_ASSIGNMENT
        public static implicit operator ExtensionVersionIDType(System.String value)
        {
             return string.IsNullOrEmpty(value) ? null : new ExtensionVersionIDType { Value = value };
        }

        public static implicit operator System.String(ExtensionVersionIDType @this)
        {
             return @this.Value;
        }
#endif
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    public partial class ExtensionURIType : IdentifierType
    {
        
#if USE_IMPLICIT_ASSIGNMENT
        public static implicit operator ExtensionURIType(System.String value)
        {
             return string.IsNullOrEmpty(value) ? null : new ExtensionURIType { Value = value };
        }

        public static implicit operator System.String(ExtensionURIType @this)
        {
             return @this.Value;
        }
#endif
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    public partial class ExtensionAgencyURIType : IdentifierType
    {
        
#if USE_IMPLICIT_ASSIGNMENT
        public static implicit operator ExtensionAgencyURIType(System.String value)
        {
             return string.IsNullOrEmpty(value) ? null : new ExtensionAgencyURIType { Value = value };
        }

        public static implicit operator System.String(ExtensionAgencyURIType @this)
        {
             return @this.Value;
        }
#endif
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    public partial class ExtensionAgencyIDType : IdentifierType
    {
        
#if USE_IMPLICIT_ASSIGNMENT
        public static implicit operator ExtensionAgencyIDType(System.String value)
        {
             return string.IsNullOrEmpty(value) ? null : new ExtensionAgencyIDType { Value = value };
        }

        public static implicit operator System.String(ExtensionAgencyIDType @this)
        {
             return @this.Value;
        }
#endif
    }
}
