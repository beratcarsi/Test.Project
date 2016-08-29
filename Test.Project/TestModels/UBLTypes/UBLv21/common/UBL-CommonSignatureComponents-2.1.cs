namespace EFatura.Core.UBLTypes.UBLv21.Csc
{
    using Sac;
    
    
    /// <summary>
    /// ComponentType: ABIE
    /// <para>DictionaryEntryName: UBL Document Signatures. Details</para>
    /// <para>Definition: This class collects all signature information for a document.</para>
    /// <para>ObjectClass: UBL Document Signatures</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonSignatureComponents-2")]
#if USE_UBL_XMLROOTATTRIBUTE
    [System.Xml.Serialization.XmlRootAttribute("UBLDocumentSignatures", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonSignatureComponents-2", IsNullable=false)]
#endif
    public partial class UBLDocumentSignaturesType
    {
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: UBL Document Signatures. Signature Information</para>
        /// <para>Definition: Each of these is scaffolding for a single digital signature.</para>
        /// <para>Cardinality: 1..n</para>
        /// <para>ObjectClass: UBL Document Signatures</para>
        /// <para>PropertyTerm: Signature Information</para>
        /// <para>AssociatedObjectClass: Signature Information</para>
        /// <para>RepresentationTerm: Signature Information</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("SignatureInformation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:SignatureAggregateComponents-2")]
        public SignatureInformationType[] SignatureInformation { get; set; }
    }
}
