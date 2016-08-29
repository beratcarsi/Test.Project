namespace EFatura.Core.UBLTypes.UBLv21.Sac
{
    using Udt;
    using Sbc;
    using DS;
    
    
    /// <summary>
    /// ComponentType: ABIE
    /// <para>DictionaryEntryName: Signature Information. Details</para>
    /// <para>Definition: This class captures a single signature and optionally associates to a signature in the document with the corresponding identifier.</para>
    /// <para>ObjectClass: Signature Information</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:SignatureAggregateComponents-2")]
#if USE_UBL_XMLROOTATTRIBUTE
    [System.Xml.Serialization.XmlRootAttribute("SignatureInformation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:SignatureAggregateComponents-2", IsNullable=false)]
#endif
    public partial class SignatureInformationType
    {
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Signature Information. Identifier</para>
        /// <para>Definition: This specifies the identifier of the signature distinguishing it from other signatures.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Signature Information</para>
        /// <para>PropertyTerm: Identifier</para>
        /// <para>RepresentationTerm: Identifier</para>
        /// <para>DataType: Identifier. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType ID { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Signature Information. Referenced Signature Identifier. Identifier</para>
        /// <para>Definition: This associates this signature with the identifier of a signature business object in the document.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Signature Information</para>
        /// <para>PropertyTerm: Referenced Signature Identifier</para>
        /// <para>RepresentationTerm: Identifier</para>
        /// <para>DataType: Identifier. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:SignatureBasicComponents-2")]
        public ReferencedSignatureIDType ReferencedSignatureID { get; set; }
        
        /// <summary>
        /// This is a single digital signature as defined by the W3C specification.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType1 Signature { get; set; }
    }
}
