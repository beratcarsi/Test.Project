namespace EFatura.Core.UBLTypes.UBLv21.Udt
{
    using Sbc;
    using Ext;
    using Cctscct;
    
    
    /// <summary>
    /// UniqueID: UBLUDT0000011
    /// <para>CategoryCode: UDT</para>
    /// <para>DictionaryEntryName: Identifier. Type</para>
    /// <para>VersionID: 1.0</para>
    /// <para>Definition: A character string to identify and uniquely distinguish one instance of an object in an identification scheme from all other objects in the same scheme, together with relevant supplementary information.</para>
    /// <para>RepresentationTermName: Identifier</para>
    /// <para>PrimitiveType: string</para>
    /// <para>UsageRule: Other supplementary components in the CCT are captured as part of the token and name for the schema module containing the identifier list and thus, are not declared as attributes.</para>
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReferencedSignatureIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtensionVersionIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtensionURIType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtensionAgencyURIType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtensionAgencyIDType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class IdentifierType : cctscctIdentifierType
    {
        
#if USE_IMPLICIT_ASSIGNMENT
        public static implicit operator IdentifierType(System.String value)
        {
             return string.IsNullOrEmpty(value) ? null : new IdentifierType { Value = value };
        }

        public static implicit operator System.String(IdentifierType @this)
        {
             return @this.Value;
        }
#endif
    }
    
    /// <summary>
    /// UniqueID: UBLUDT000001
    /// <para>CategoryCode: UDT</para>
    /// <para>DictionaryEntryName: Amount. Type</para>
    /// <para>VersionID: 1.0</para>
    /// <para>Definition: A number of monetary units specified using a given unit of currency.</para>
    /// <para>RepresentationTermName: Amount</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class AmountType : cctscctAmountType
    {
    }
    
    /// <summary>
    /// UniqueID: UBLUDT0000019
    /// <para>CategoryCode: UDT</para>
    /// <para>DictionaryEntryName: Text. Type</para>
    /// <para>VersionID: 1.0</para>
    /// <para>Definition: A character string (i.e. a finite set of characters), generally in the form of words of a language.</para>
    /// <para>RepresentationTermName: Text</para>
    /// <para>PrimitiveType: string</para>
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtensionReasonType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtensionAgencyNameType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class TextType : cctscctTextType
    {
        
#if USE_IMPLICIT_ASSIGNMENT
        public static implicit operator TextType(System.String value)
        {
             return string.IsNullOrEmpty(value) ? null : new TextType { Value = value };
        }

        public static implicit operator System.String(TextType @this)
        {
             return @this.Value;
        }
#endif
    }
    
    /// <summary>
    /// UniqueID: UBLUDT0000020
    /// <para>CategoryCode: UDT</para>
    /// <para>DictionaryEntryName: Name. Type</para>
    /// <para>VersionID: 1.0</para>
    /// <para>Definition: A character string that constitutes the distinctive designation of a person, place, thing or concept.</para>
    /// <para>RepresentationTermName: Name</para>
    /// <para>PrimitiveType: string</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class NameType : cctscctTextType
    {
        
#if USE_IMPLICIT_ASSIGNMENT
        public static implicit operator NameType(System.String value)
        {
             return string.IsNullOrEmpty(value) ? null : new NameType { Value = value };
        }

        public static implicit operator System.String(NameType @this)
        {
             return @this.Value;
        }
#endif
    }
    
    /// <summary>
    /// UniqueID: UBLUDT000007
    /// <para>CategoryCode: UDT</para>
    /// <para>DictionaryEntryName: Code. Type</para>
    /// <para>VersionID: 1.0</para>
    /// <para>Definition: A character string (letters, figures, or symbols) that for brevity and/or language independence may be used to represent or replace a definitive value or text of an attribute, together with relevant supplementary information.</para>
    /// <para>RepresentationTermName: Code</para>
    /// <para>PrimitiveType: string</para>
    /// <para>UsageRule: Other supplementary components in the CCT are captured as part of the token and name for the schema module containing the code list and thus, are not declared as attributes.</para>
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtensionReasonCodeType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class CodeType : cctscctCodeType
    {
        
#if USE_IMPLICIT_ASSIGNMENT
        public static implicit operator CodeType(System.String value)
        {
             return string.IsNullOrEmpty(value) ? null : new CodeType { Value = value };
        }

        public static implicit operator System.String(CodeType @this)
        {
             return @this.Value;
        }
#endif
    }
    
    /// <summary>
    /// UniqueID: UBLUDT0000018
    /// <para>CategoryCode: UDT</para>
    /// <para>DictionaryEntryName: Quantity. Type</para>
    /// <para>VersionID: 1.0</para>
    /// <para>Definition: A counted number of non-monetary units, possibly including a fractional part.</para>
    /// <para>RepresentationTermName: Quantity</para>
    /// <para>PrimitiveType: decimal</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class QuantityType : cctscctQuantityType
    {
        
#if USE_IMPLICIT_ASSIGNMENT
        public static implicit operator QuantityType(System.Decimal value)
        {
             return new QuantityType { Value = value };
        }

        public static implicit operator System.Decimal(QuantityType @this)
        {
             return @this.Value;
        }
#endif
    }
    
    /// <summary>
    /// UniqueID: UBLUDT0000014
    /// <para>CategoryCode: UDT</para>
    /// <para>DictionaryEntryName: Numeric. Type</para>
    /// <para>VersionID: 1.0</para>
    /// <para>Definition: Numeric information that is assigned or is determined by calculation, counting, or sequencing. It does not require a unit of quantity or unit of measure.</para>
    /// <para>RepresentationTermName: Numeric</para>
    /// <para>PrimitiveType: string</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class NumericType : cctscctNumericType
    {
        
#if USE_IMPLICIT_ASSIGNMENT
        public static implicit operator NumericType(System.Decimal value)
        {
             return new NumericType { Value = value };
        }

        public static implicit operator System.Decimal(NumericType @this)
        {
             return @this.Value;
        }
#endif
    }
    
    /// <summary>
    /// UniqueID: UBLUDT0000017
    /// <para>CategoryCode: UDT</para>
    /// <para>VersionID: 1.0</para>
    /// <para>DictionaryEntryName: Rate. Type</para>
    /// <para>Definition: A numeric expression of a rate that is assigned or is determined by calculation, counting, or sequencing. It does not require a unit of quantity or unit of measure.</para>
    /// <para>RepresentationTermName: Rate</para>
    /// <para>PrimitiveType: string</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class RateType : cctscctNumericType
    {
        
#if USE_IMPLICIT_ASSIGNMENT
        public static implicit operator RateType(System.Decimal value)
        {
             return new RateType { Value = value };
        }

        public static implicit operator System.Decimal(RateType @this)
        {
             return @this.Value;
        }
#endif
    }
    
    /// <summary>
    /// UniqueID: UBLUDT0000016
    /// <para>CategoryCode: UDT</para>
    /// <para>VersionID: 1.0</para>
    /// <para>DictionaryEntryName: Percent. Type</para>
    /// <para>Definition: Numeric information that is assigned or is determined by calculation, counting, or sequencing and is expressed as a percentage. It does not require a unit of quantity or unit of measure.</para>
    /// <para>RepresentationTermName: Percent</para>
    /// <para>PrimitiveType: string</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class PercentType : cctscctNumericType
    {
        
#if USE_IMPLICIT_ASSIGNMENT
        public static implicit operator PercentType(System.Decimal value)
        {
             return new PercentType { Value = value };
        }

        public static implicit operator System.Decimal(PercentType @this)
        {
             return @this.Value;
        }
#endif
    }
    
    /// <summary>
    /// UniqueID: UBLUDT0000015
    /// <para>CategoryCode: UDT</para>
    /// <para>VersionID: 1.0</para>
    /// <para>DictionaryEntryName: Value. Type</para>
    /// <para>Definition: Numeric information that is assigned or is determined by calculation, counting, or sequencing. It does not require a unit of quantity or unit of measure.</para>
    /// <para>RepresentationTermName: Value</para>
    /// <para>PrimitiveType: string</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class ValueType : cctscctNumericType
    {
        
#if USE_IMPLICIT_ASSIGNMENT
        public static implicit operator ValueType(System.Decimal value)
        {
             return new ValueType { Value = value };
        }

        public static implicit operator System.Decimal(ValueType @this)
        {
             return @this.Value;
        }
#endif
    }
    
    /// <summary>
    /// UniqueID: UBLUDT0000013
    /// <para>CategoryCode: UDT</para>
    /// <para>DictionaryEntryName: Measure. Type</para>
    /// <para>VersionID: 1.0</para>
    /// <para>Definition: A numeric value determined by measuring an object using a specified unit of measure.</para>
    /// <para>RepresentationTermName: Measure</para>
    /// <para>PropertyTermName: Type</para>
    /// <para>PrimitiveType: decimal</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class MeasureType : cctscctMeasureType
    {
    }
    
    /// <summary>
    /// UniqueID: UBLUDT000009
    /// <para>CategoryCode: UDT</para>
    /// <para>DictionaryEntryName: Date. Type</para>
    /// <para>VersionID: 1.0</para>
    /// <para>Definition: One calendar day according the Gregorian calendar.</para>
    /// <para>RepresentationTermName: Date</para>
    /// <para>PrimitiveType: string</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class DateType
    {
        
        [System.Xml.Serialization.XmlTextAttribute(DataType="date")]
        public System.DateTime Value { get; set; }
        
#if USE_IMPLICIT_ASSIGNMENT
        public static implicit operator DateType(System.DateTime value)
        {
             return new DateType { Value = value };
        }

        public static implicit operator System.DateTime(DateType @this)
        {
             return @this.Value;
        }
#endif
    }
    
    /// <summary>
    /// UniqueID: UBLUDT0000010
    /// <para>CategoryCode: UDT</para>
    /// <para>DictionaryEntryName: Time. Type</para>
    /// <para>VersionID: 1.0</para>
    /// <para>Definition: An instance of time that occurs every day.</para>
    /// <para>RepresentationTermName: Time</para>
    /// <para>PrimitiveType: string</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class TimeType
    {
        
        // New serialized string type is declared in file UBL-UnqualifiedDataTypes-2.1.partial.cs
        [System.Xml.Serialization.XmlIgnore()]
        public System.DateTime Value { get; set; }
        
#if USE_IMPLICIT_ASSIGNMENT
        public static implicit operator TimeType(System.DateTime value)
        {
             return new TimeType { Value = value };
        }

        public static implicit operator System.DateTime(TimeType @this)
        {
             return @this.Value;
        }
#endif
    }
    
    /// <summary>
    /// UniqueID: UBLUDT0000012
    /// <para>CategoryCode: UDT</para>
    /// <para>DictionaryEntryName: Indicator. Type</para>
    /// <para>VersionID: 1.0</para>
    /// <para>Definition: A list of two mutually exclusive Boolean values that express the only possible states of a property.</para>
    /// <para>RepresentationTermName: Indicator</para>
    /// <para>PrimitiveType: string</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class IndicatorType
    {
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public bool Value { get; set; }
        
#if USE_IMPLICIT_ASSIGNMENT
        public static implicit operator IndicatorType(System.Boolean value)
        {
             return new IndicatorType { Value = value };
        }

        public static implicit operator System.Boolean(IndicatorType @this)
        {
             return @this.Value;
        }
#endif
    }
    
    /// <summary>
    /// UniqueID: UBLUDT000002
    /// <para>CategoryCode: UDT</para>
    /// <para>DictionaryEntryName: Binary Object. Type</para>
    /// <para>VersionID: 1.0</para>
    /// <para>Definition: A set of finite-length sequences of binary octets.</para>
    /// <para>RepresentationTermName: Binary Object</para>
    /// <para>PrimitiveType: binary</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class BinaryObjectType : cctscctBinaryObjectType
    {
    }
    
    /// <summary>
    /// UniqueID: UBLUDT000006
    /// <para>CategoryCode: UDT</para>
    /// <para>DictionaryEntryName: Video. Type</para>
    /// <para>VersionID: 1.0</para>
    /// <para>Definition: A video representation.</para>
    /// <para>RepresentationTermName: Video</para>
    /// <para>PrimitiveType: binary</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class VideoType : cctscctBinaryObjectType
    {
    }
    
    /// <summary>
    /// UniqueID: UBLUDT000005
    /// <para>CategoryCode: UDT</para>
    /// <para>DictionaryEntryName: Sound. Type</para>
    /// <para>VersionID: 1.0</para>
    /// <para>Definition: An audio representation.</para>
    /// <para>RepresentationTermName: Sound</para>
    /// <para>PrimitiveType: binary</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class SoundType : cctscctBinaryObjectType
    {
    }
    
    /// <summary>
    /// UniqueID: UBLUDT000004
    /// <para>CategoryCode: UDT</para>
    /// <para>DictionaryEntryName: Picture. Type</para>
    /// <para>VersionID: 1.0</para>
    /// <para>Definition: A diagram, graph, mathematical curve, or similar representation.</para>
    /// <para>RepresentationTermName: Picture</para>
    /// <para>PrimitiveType: binary</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class PictureType : cctscctBinaryObjectType
    {
    }
    
    /// <summary>
    /// UniqueID: UBLUDT000003
    /// <para>CategoryCode: UDT</para>
    /// <para>DictionaryEntryName: Graphic. Type</para>
    /// <para>VersionID: 1.0</para>
    /// <para>Definition: A diagram, graph, mathematical curve, or similar representation.</para>
    /// <para>RepresentationTermName: Graphic</para>
    /// <para>PrimitiveType: binary</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class GraphicType : cctscctBinaryObjectType
    {
    }
}
