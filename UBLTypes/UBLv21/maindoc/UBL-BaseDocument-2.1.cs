namespace EFatura.Core.UBLTypes.UBLv21
{
    using Udt;
    using Ext;
    
    /// <summary>
    /// This is a custom generated class that holds all the props/fields common to all UBL maindocs.
    /// <para>You won't find a matching xsd file where it originates from.</para>
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InvoiceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationResponseType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:BaseDocument-2")]
    [System.Xml.Serialization.XmlRootAttribute("UblBaseDocument", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:BaseDocument-2", IsNullable=false)]
    public abstract partial class UblBaseDocumentType
    {
        
        /// <summary>
        /// A container for all extensions present in the document.
        /// </summary>
        [System.Xml.Serialization.XmlArrayAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
        [System.Xml.Serialization.XmlArrayItemAttribute("UBLExtension", IsNullable=false)]
        public UBLExtensionType[] UBLExtensions { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Application Response. UBL Version Identifier. Identifier</para>
        /// <para>Definition: Identifies the earliest version of the UBL 2 schema for this document type that defines all of the elements that might be encountered in the current instance.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Application Response</para>
        /// <para>PropertyTerm: UBL Version Identifier</para>
        /// <para>RepresentationTerm: Identifier</para>
        /// <para>DataType: Identifier. Type</para>
        /// <para>Examples: 2.0.5</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType UBLVersionID { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Application Response. Customization Identifier. Identifier</para>
        /// <para>Definition: Identifies a user-defined customization of UBL for a specific use.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Application Response</para>
        /// <para>PropertyTerm: Customization Identifier</para>
        /// <para>RepresentationTerm: Identifier</para>
        /// <para>DataType: Identifier. Type</para>
        /// <para>Examples: NES</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType CustomizationID { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Application Response. Profile Identifier. Identifier</para>
        /// <para>Definition: Identifies a user-defined profile of the customization of UBL being used.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Application Response</para>
        /// <para>PropertyTerm: Profile Identifier</para>
        /// <para>RepresentationTerm: Identifier</para>
        /// <para>DataType: Identifier. Type</para>
        /// <para>Examples: BasicProcurementProcess</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType ProfileID { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Application Response. Profile Execution Identifier. Identifier</para>
        /// <para>Definition: Identifies an instance of executing a profile, to associate all transactions in a collaboration.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Application Response</para>
        /// <para>PropertyTerm: Profile Execution Identifier</para>
        /// <para>RepresentationTerm: Identifier</para>
        /// <para>DataType: Identifier. Type</para>
        /// <para>Examples: BPP-1001</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType ProfileExecutionID { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Application Response. Identifier</para>
        /// <para>Definition: An identifier for this document, assigned by the sender.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Application Response</para>
        /// <para>PropertyTerm: Identifier</para>
        /// <para>RepresentationTerm: Identifier</para>
        /// <para>DataType: Identifier. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType ID { get; set; }
    }
}
