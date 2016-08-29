namespace EFatura.Core.UBLTypes.UBLv21.Sbc
{
    using Udt;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:SignatureBasicComponents-2")]
    public partial class ReferencedSignatureIDType : IdentifierType
    {
        
#if USE_IMPLICIT_ASSIGNMENT
        public static implicit operator ReferencedSignatureIDType(System.String value)
        {
             return string.IsNullOrEmpty(value) ? null : new ReferencedSignatureIDType { Value = value };
        }

        public static implicit operator System.String(ReferencedSignatureIDType @this)
        {
             return @this.Value;
        }
#endif
    }
}
