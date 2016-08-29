namespace EFatura.Core.UBLTypes.UBLv21.Xades
{
    using DS;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.4.1#")]
#if USE_UBL_XMLROOTATTRIBUTE
    [System.Xml.Serialization.XmlRootAttribute("TimeStampValidationData", Namespace = "http://uri.etsi.org/01903/v1.4.1#", IsNullable=false)]
#endif
    public partial class ValidationDataType
    {
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
        public CertificateValuesType CertificateValues { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
        public RevocationValuesType RevocationValues { get; set; }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string Id { get; set; }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string UR { get; set; }
    }
}
