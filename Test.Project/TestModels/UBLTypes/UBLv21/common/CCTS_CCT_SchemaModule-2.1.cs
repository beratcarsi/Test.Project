namespace EFatura.Core.UBLTypes.UBLv21.Cctscct
{
    using Udt;
    using Sbc;
    using Ext;
    
    
    /// <summary>
    /// UniqueID: UNDT000011
    /// <para>CategoryCode: CCT</para>
    /// <para>DictionaryEntryName: Identifier. Type</para>
    /// <para>VersionID: 1.0</para>
    /// <para>Definition: A character string to identify and distinguish uniquely, one instance of an object in an identification scheme from all other objects in the same scheme together with relevant supplementary information.</para>
    /// <para>RepresentationTermName: Identifier</para>
    /// <para>PrimitiveType: string</para>
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IdentifierType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReferencedSignatureIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtensionVersionIDType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtensionURIType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtensionAgencyURIType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtensionAgencyIDType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    public abstract partial class cctscctIdentifierType
    {
        
        /// <summary>
        /// UniqueID: UNDT000011-SC2
        /// <para>CategoryCode: SC</para>
        /// <para>DictionaryEntryName: Identification Scheme. Identifier</para>
        /// <para>Definition: The identification of the identification scheme.</para>
        /// <para>ObjectClass: Identification Scheme</para>
        /// <para>PropertyTermName: Identification</para>
        /// <para>RepresentationTermName: Identifier</para>
        /// <para>PrimitiveType: string</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string schemeID { get; set; }
        
        /// <summary>
        /// UniqueID: UNDT000011-SC3
        /// <para>CategoryCode: SC</para>
        /// <para>DictionaryEntryName: Identification Scheme. Name. Text</para>
        /// <para>Definition: The name of the identification scheme.</para>
        /// <para>ObjectClass: Identification Scheme</para>
        /// <para>PropertyTermName: Name</para>
        /// <para>RepresentationTermName: Text</para>
        /// <para>PrimitiveType: string</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string schemeName { get; set; }
        
        /// <summary>
        /// UniqueID: UNDT000011-SC4
        /// <para>CategoryCode: SC</para>
        /// <para>DictionaryEntryName: Identification Scheme Agency. Identifier</para>
        /// <para>Definition: The identification of the agency that maintains the identification scheme.</para>
        /// <para>ObjectClass: Identification Scheme Agency</para>
        /// <para>PropertyTermName: Identification</para>
        /// <para>RepresentationTermName: Identifier</para>
        /// <para>PrimitiveType: string</para>
        /// <para>UsageRule: Defaults to the UN/EDIFACT data element 3055 code list.</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string schemeAgencyID { get; set; }
        
        /// <summary>
        /// UniqueID: UNDT000011-SC5
        /// <para>CategoryCode: SC</para>
        /// <para>DictionaryEntryName: Identification Scheme Agency. Name. Text</para>
        /// <para>Definition: The name of the agency that maintains the identification scheme.</para>
        /// <para>ObjectClass: Identification Scheme Agency</para>
        /// <para>PropertyTermName: Agency Name</para>
        /// <para>RepresentationTermName: Text</para>
        /// <para>PrimitiveType: string</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string schemeAgencyName { get; set; }
        
        /// <summary>
        /// UniqueID: UNDT000011-SC6
        /// <para>CategoryCode: SC</para>
        /// <para>DictionaryEntryName: Identification Scheme. Version. Identifier</para>
        /// <para>Definition: The version of the identification scheme.</para>
        /// <para>ObjectClass: Identification Scheme</para>
        /// <para>PropertyTermName: Version</para>
        /// <para>RepresentationTermName: Identifier</para>
        /// <para>PrimitiveType: string</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string schemeVersionID { get; set; }
        
        /// <summary>
        /// UniqueID: UNDT000011-SC7
        /// <para>CategoryCode: SC</para>
        /// <para>DictionaryEntryName: Identification Scheme Data. Uniform Resource. Identifier</para>
        /// <para>Definition: The Uniform Resource Identifier that identifies where the identification scheme data is located.</para>
        /// <para>ObjectClass: Identification Scheme Data</para>
        /// <para>PropertyTermName: Uniform Resource Identifier</para>
        /// <para>RepresentationTermName: Identifier</para>
        /// <para>PrimitiveType: string</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string schemeDataURI { get; set; }
        
        /// <summary>
        /// UniqueID: UNDT000011-SC8
        /// <para>CategoryCode: SC</para>
        /// <para>DictionaryEntryName: Identification Scheme. Uniform Resource. Identifier</para>
        /// <para>Definition: The Uniform Resource Identifier that identifies where the identification scheme is located.</para>
        /// <para>ObjectClass: Identification Scheme</para>
        /// <para>PropertyTermName: Uniform Resource Identifier</para>
        /// <para>RepresentationTermName: Identifier</para>
        /// <para>PrimitiveType: string</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string schemeURI { get; set; }
        
        [System.Xml.Serialization.XmlTextAttribute(DataType="normalizedString")]
        public string Value { get; set; }
    }
    
    /// <summary>
    /// UniqueID: UNDT000001
    /// <para>CategoryCode: CCT</para>
    /// <para>DictionaryEntryName: Amount. Type</para>
    /// <para>VersionID: 1.0</para>
    /// <para>Definition: A number of monetary units specified in a currency where the unit of the currency is explicit or implied.</para>
    /// <para>RepresentationTermName: Amount</para>
    /// <para>PrimitiveType: decimal</para>
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AmountType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    public abstract partial class cctscctAmountType
    {
        
        /// <summary>
        /// UniqueID: UNDT000001-SC2
        /// <para>CategoryCode: SC</para>
        /// <para>DictionaryEntryName: Amount Currency. Identifier</para>
        /// <para>Definition: The currency of the amount.</para>
        /// <para>ObjectClass: Amount Currency</para>
        /// <para>PropertyTermName: Identification</para>
        /// <para>RepresentationTermName: Identifier</para>
        /// <para>PrimitiveType: string</para>
        /// <para>UsageRule: Reference UNECE Rec 9, using 3-letter alphabetic codes.</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string currencyID { get; set; }
        
        /// <summary>
        /// UniqueID: UNDT000001-SC3
        /// <para>CategoryCode: SC</para>
        /// <para>DictionaryEntryName: Amount Currency. Code List Version. Identifier</para>
        /// <para>Definition: The VersionID of the UN/ECE Rec9 code list.</para>
        /// <para>ObjectClass: Amount Currency</para>
        /// <para>PropertyTermName: Code List Version</para>
        /// <para>RepresentationTermName: Identifier</para>
        /// <para>PrimitiveType: string</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string currencyCodeListVersionID { get; set; }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value { get; set; }
    }
    
    /// <summary>
    /// UniqueID: UNDT000019
    /// <para>CategoryCode: CCT</para>
    /// <para>DictionaryEntryName: Text. Type</para>
    /// <para>VersionID: 1.0</para>
    /// <para>Definition: A character string (i.e. a finite set of characters) generally in the form of words of a language.</para>
    /// <para>RepresentationTermName: Text</para>
    /// <para>PrimitiveType: string</para>
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TextType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtensionReasonType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtensionAgencyNameType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    public abstract partial class cctscctTextType
    {
        
        /// <summary>
        /// UniqueID: UNDT000019-SC2
        /// <para>CategoryCode: SC</para>
        /// <para>DictionaryEntryName: Language. Identifier</para>
        /// <para>Definition: The identifier of the language used in the content component.</para>
        /// <para>ObjectClass: Language</para>
        /// <para>PropertyTermName: Identification</para>
        /// <para>RepresentationTermName: Identifier</para>
        /// <para>PrimitiveType: string</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="language")]
        public string languageID { get; set; }
        
        /// <summary>
        /// UniqueID: UNDT000019-SC3
        /// <para>CategoryCode: SC</para>
        /// <para>DictionaryEntryName: Language. Locale. Identifier</para>
        /// <para>Definition: The identification of the locale of the language.</para>
        /// <para>ObjectClass: Language</para>
        /// <para>PropertyTermName: Locale</para>
        /// <para>RepresentationTermName: Identifier</para>
        /// <para>PrimitiveType: string</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string languageLocaleID { get; set; }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value { get; set; }
    }
    
    /// <summary>
    /// UniqueID: UNDT000007
    /// <para>CategoryCode: CCT</para>
    /// <para>DictionaryEntryName: Code. Type</para>
    /// <para>VersionID: 1.0</para>
    /// <para>Definition: A character string (letters, figures, or symbols) that for brevity and/or languange independence may be used to represent or replace a definitive value or text of an attribute together with relevant supplementary information.</para>
    /// <para>RepresentationTermName: Code</para>
    /// <para>PrimitiveType: string</para>
    /// <para>UsageRule: Should not be used if the character string identifies an instance of an object class or an object in the real world, in which case the Identifier. Type should be used.</para>
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CodeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtensionReasonCodeType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    public abstract partial class cctscctCodeType
    {
        
        /// <summary>
        /// UniqueID: UNDT000007-SC2
        /// <para>CategoryCode: SC</para>
        /// <para>DictionaryEntryName: Code List. Identifier</para>
        /// <para>Definition: The identification of a list of codes.</para>
        /// <para>ObjectClass: Code List</para>
        /// <para>PropertyTermName: Identification</para>
        /// <para>RepresentationTermName: Identifier</para>
        /// <para>PrimitiveType: string</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string listID { get; set; }
        
        /// <summary>
        /// UniqueID: UNDT000007-SC3
        /// <para>CategoryCode: SC</para>
        /// <para>DictionaryEntryName: Code List. Agency. Identifier</para>
        /// <para>Definition: An agency that maintains one or more lists of codes.</para>
        /// <para>ObjectClass: Code List</para>
        /// <para>PropertyTermName: Agency</para>
        /// <para>RepresentationTermName: Identifier</para>
        /// <para>PrimitiveType: string</para>
        /// <para>UsageRule: Defaults to the UN/EDIFACT data element 3055 code list.</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string listAgencyID { get; set; }
        
        /// <summary>
        /// UniqueID: UNDT000007-SC4
        /// <para>CategoryCode: SC</para>
        /// <para>DictionaryEntryName: Code List. Agency Name. Text</para>
        /// <para>Definition: The name of the agency that maintains the list of codes.</para>
        /// <para>ObjectClass: Code List</para>
        /// <para>PropertyTermName: Agency Name</para>
        /// <para>RepresentationTermName: Text</para>
        /// <para>PrimitiveType: string</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string listAgencyName { get; set; }
        
        /// <summary>
        /// UniqueID: UNDT000007-SC5
        /// <para>CategoryCode: SC</para>
        /// <para>DictionaryEntryName: Code List. Name. Text</para>
        /// <para>Definition: The name of a list of codes.</para>
        /// <para>ObjectClass: Code List</para>
        /// <para>PropertyTermName: Name</para>
        /// <para>RepresentationTermName: Text</para>
        /// <para>PrimitiveType: string</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string listName { get; set; }
        
        /// <summary>
        /// UniqueID: UNDT000007-SC6
        /// <para>CategoryCode: SC</para>
        /// <para>DictionaryEntryName: Code List. Version. Identifier</para>
        /// <para>Definition: The version of the list of codes.</para>
        /// <para>ObjectClass: Code List</para>
        /// <para>PropertyTermName: Version</para>
        /// <para>RepresentationTermName: Identifier</para>
        /// <para>PrimitiveType: string</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string listVersionID { get; set; }
        
        /// <summary>
        /// UniqueID: UNDT000007-SC7
        /// <para>CategoryCode: SC</para>
        /// <para>DictionaryEntryName: Code. Name. Text</para>
        /// <para>Definition: The textual equivalent of the code content component.</para>
        /// <para>ObjectClass: Code</para>
        /// <para>PropertyTermName: Name</para>
        /// <para>RepresentationTermName: Text</para>
        /// <para>PrimitiveType: string</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name { get; set; }
        
        /// <summary>
        /// UniqueID: UNDT000007-SC8
        /// <para>CategoryCode: SC</para>
        /// <para>DictionaryEntryName: Language. Identifier</para>
        /// <para>Definition: The identifier of the language used in the code name.</para>
        /// <para>ObjectClass: Language</para>
        /// <para>PropertyTermName: Identification</para>
        /// <para>RepresentationTermName: Identifier</para>
        /// <para>PrimitiveType: string</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="language")]
        public string languageID { get; set; }
        
        /// <summary>
        /// UniqueID: UNDT000007-SC9
        /// <para>CategoryCode: SC</para>
        /// <para>DictionaryEntryName: Code List. Uniform Resource. Identifier</para>
        /// <para>Definition: The Uniform Resource Identifier that identifies where the code list is located.</para>
        /// <para>ObjectClass: Code List</para>
        /// <para>PropertyTermName: Uniform Resource Identifier</para>
        /// <para>RepresentationTermName: Identifier</para>
        /// <para>PrimitiveType: string</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string listURI { get; set; }
        
        /// <summary>
        /// UniqueID: UNDT000007-SC10
        /// <para>CategoryCode: SC</para>
        /// <para>DictionaryEntryName: Code List Scheme. Uniform Resource. Identifier</para>
        /// <para>Definition: The Uniform Resource Identifier that identifies where the code list scheme is located.</para>
        /// <para>ObjectClass: Code List Scheme</para>
        /// <para>PropertyTermName: Uniform Resource Identifier</para>
        /// <para>RepresentationTermName: Identifier</para>
        /// <para>PrimitiveType: string</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string listSchemeURI { get; set; }
        
        [System.Xml.Serialization.XmlTextAttribute(DataType="normalizedString")]
        public string Value { get; set; }
    }
    
    /// <summary>
    /// UniqueID: UNDT000018
    /// <para>CategoryCode: CCT</para>
    /// <para>DictionaryEntryName: Quantity. Type</para>
    /// <para>VersionID: 1.0</para>
    /// <para>Definition: A counted number of non-monetary units possibly including fractions.</para>
    /// <para>RepresentationTermName: Quantity</para>
    /// <para>PrimitiveType: decimal</para>
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(QuantityType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    public abstract partial class cctscctQuantityType
    {
        
        /// <summary>
        /// UniqueID: UNDT000018-SC2
        /// <para>CategoryCode: SC</para>
        /// <para>DictionaryEntryName: Quantity. Unit. Code</para>
        /// <para>Definition: The unit of the quantity</para>
        /// <para>ObjectClass: Quantity</para>
        /// <para>PropertyTermName: Unit Code</para>
        /// <para>RepresentationTermName: Code</para>
        /// <para>PrimitiveType: string</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string unitCode { get; set; }
        
        /// <summary>
        /// UniqueID: UNDT000018-SC3
        /// <para>CategoryCode: SC</para>
        /// <para>DictionaryEntryName: Quantity Unit. Code List. Identifier</para>
        /// <para>Definition: The quantity unit code list.</para>
        /// <para>ObjectClass: Quantity Unit</para>
        /// <para>PropertyTermName: Code List</para>
        /// <para>RepresentationTermName: Identifier</para>
        /// <para>PrimitiveType: string</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string unitCodeListID { get; set; }
        
        /// <summary>
        /// UniqueID: UNDT000018-SC4
        /// <para>CategoryCode: SC</para>
        /// <para>DictionaryEntryName: Quantity Unit. Code List Agency. Identifier</para>
        /// <para>Definition: The identification of the agency that maintains the quantity unit code list</para>
        /// <para>ObjectClass: Quantity Unit</para>
        /// <para>PropertyTermName: Code List Agency</para>
        /// <para>RepresentationTermName: Identifier</para>
        /// <para>PrimitiveType: string</para>
        /// <para>UsageRule: Defaults to the UN/EDIFACT data element 3055 code list.</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string unitCodeListAgencyID { get; set; }
        
        /// <summary>
        /// UniqueID: UNDT000018-SC5
        /// <para>CategoryCode: SC</para>
        /// <para>DictionaryEntryName: Quantity Unit. Code List Agency Name. Text</para>
        /// <para>Definition: The name of the agency which maintains the quantity unit code list.</para>
        /// <para>ObjectClass: Quantity Unit</para>
        /// <para>PropertyTermName: Code List Agency Name</para>
        /// <para>RepresentationTermName: Text</para>
        /// <para>PrimitiveType: string</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string unitCodeListAgencyName { get; set; }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value { get; set; }
    }
    
    /// <summary>
    /// UniqueID: UNDT000014
    /// <para>CategoryCode: CCT</para>
    /// <para>DictionaryEntryName: Numeric. Type</para>
    /// <para>VersionID: 1.0</para>
    /// <para>Definition: Numeric information that is assigned or is determined by calculation, counting, or sequencing. It does not require a unit of quantity or unit of measure.</para>
    /// <para>RepresentationTermName: Numeric</para>
    /// <para>PrimitiveType: string</para>
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PercentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ValueType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NumericType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    public abstract partial class cctscctNumericType
    {
        
        /// <summary>
        /// UniqueID: UNDT000014-SC2
        /// <para>CategoryCode: SC</para>
        /// <para>DictionaryEntryName: Numeric. Format. Text</para>
        /// <para>Definition: Whether the number is an integer, decimal, real number or percentage.</para>
        /// <para>ObjectClass: Numeric</para>
        /// <para>PropertyTermName: Format</para>
        /// <para>RepresentationTermName: Text</para>
        /// <para>PrimitiveType: string</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string format { get; set; }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value { get; set; }
    }
    
    /// <summary>
    /// UniqueID: UNDT000013
    /// <para>CategoryCode: CCT</para>
    /// <para>DictionaryEntryName: Measure. Type</para>
    /// <para>VersionID: 1.0</para>
    /// <para>Definition: A numeric value determined by measuring an object along with the specified unit of measure.</para>
    /// <para>RepresentationTermName: Measure</para>
    /// <para>PrimitiveType: decimal</para>
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MeasureType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    public abstract partial class cctscctMeasureType
    {
        
        /// <summary>
        /// UniqueID: UNDT000013-SC2
        /// <para>CategoryCode: SC</para>
        /// <para>DictionaryEntryName: Measure Unit. Code</para>
        /// <para>Definition: The type of unit of measure.</para>
        /// <para>ObjectClass: Measure Unit</para>
        /// <para>PropertyTermName: Code</para>
        /// <para>RepresentationTermName: Code</para>
        /// <para>PrimitiveType: string</para>
        /// <para>UsageRule: Reference UNECE Rec. 20 and X12 355</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string unitCode { get; set; }
        
        /// <summary>
        /// UniqueID: UNDT000013-SC3
        /// <para>CategoryCode: SC</para>
        /// <para>DictionaryEntryName: Measure Unit. Code List Version. Identifier</para>
        /// <para>Definition: The version of the measure unit code list.</para>
        /// <para>ObjectClass: Measure Unit</para>
        /// <para>PropertyTermName: Code List Version</para>
        /// <para>RepresentationTermName: Identifier</para>
        /// <para>PrimitiveType: string</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string unitCodeListVersionID { get; set; }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value { get; set; }
    }
    
    /// <summary>
    /// UniqueID: UNDT000002
    /// <para>CategoryCode: CCT</para>
    /// <para>DictionaryEntryName: Binary Object. Type</para>
    /// <para>VersionID: 1.0</para>
    /// <para>Definition: A set of finite-length sequences of binary octets.</para>
    /// <para>RepresentationTermName: Binary Object</para>
    /// <para>PrimitiveType: binary</para>
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VideoType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SoundType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PictureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GraphicType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BinaryObjectType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    public abstract partial class cctscctBinaryObjectType
    {
        
        /// <summary>
        /// UniqueID: UNDT000002-SC2
        /// <para>CategoryCode: SC</para>
        /// <para>DictionaryEntryName: Binary Object. Format. Text</para>
        /// <para>Definition: The format of the binary content.</para>
        /// <para>ObjectClass: Binary Object</para>
        /// <para>PropertyTermName: Format</para>
        /// <para>RepresentationTermName: Text</para>
        /// <para>PrimitiveType: string</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string format { get; set; }
        
        /// <summary>
        /// UniqueID: UNDT000002-SC3
        /// <para>CategoryCode: SC</para>
        /// <para>DictionaryEntryName: Binary Object. Mime. Code</para>
        /// <para>Definition: The mime type of the binary object.</para>
        /// <para>ObjectClass: Binary Object</para>
        /// <para>PropertyTermName: Mime</para>
        /// <para>RepresentationTermName: Code</para>
        /// <para>PrimitiveType: string</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string mimeCode { get; set; }
        
        /// <summary>
        /// UniqueID: UNDT000002-SC4
        /// <para>CategoryCode: SC</para>
        /// <para>DictionaryEntryName: Binary Object. Encoding. Code</para>
        /// <para>Definition: Specifies the decoding algorithm of the binary object.</para>
        /// <para>ObjectClass: Binary Object</para>
        /// <para>PropertyTermName: Encoding</para>
        /// <para>RepresentationTermName: Code</para>
        /// <para>PrimitiveType: string</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string encodingCode { get; set; }
        
        /// <summary>
        /// UniqueID: UNDT000002-SC5
        /// <para>CategoryCode: SC</para>
        /// <para>DictionaryEntryName: Binary Object. Character Set. Code</para>
        /// <para>Definition: The character set of the binary object if the mime type is text.</para>
        /// <para>ObjectClass: Binary Object</para>
        /// <para>PropertyTermName: Character Set</para>
        /// <para>RepresentationTermName: Code</para>
        /// <para>PrimitiveType: string</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string characterSetCode { get; set; }
        
        /// <summary>
        /// UniqueID: UNDT000002-SC6
        /// <para>CategoryCode: SC</para>
        /// <para>DictionaryEntryName: Binary Object. Uniform Resource. Identifier</para>
        /// <para>Definition: The Uniform Resource Identifier that identifies where the binary object is located.</para>
        /// <para>ObjectClass: Binary Object</para>
        /// <para>PropertyTermName: Uniform Resource Identifier</para>
        /// <para>RepresentationTermName: Identifier</para>
        /// <para>PrimitiveType: string</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string uri { get; set; }
        
        /// <summary>
        /// UniqueID: UNDT000002-SC7
        /// <para>CategoryCode: SC</para>
        /// <para>DictionaryEntryName: Binary Object. Filename.Text</para>
        /// <para>Definition: The filename of the binary object.</para>
        /// <para>ObjectClass: Binary Object</para>
        /// <para>PropertyTermName: Filename</para>
        /// <para>RepresentationTermName: Text</para>
        /// <para>PrimitiveType: string</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string filename { get; set; }
        
        [System.Xml.Serialization.XmlTextAttribute(DataType="base64Binary")]
        public byte[] Value { get; set; }
    }
}
