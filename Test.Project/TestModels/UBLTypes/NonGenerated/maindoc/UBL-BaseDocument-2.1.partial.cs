using System;
using System.Xml;
using System.Xml.Serialization;
using System.Linq;
using System.Collections.Generic;

namespace Test.Project.TestModels.UBLTypes.UBLv21
{
    public abstract class UblBaseDocumentType
    {
        private static XmlSerializerNamespaces xmlns = new XmlSerializerNamespaces(new[]
            {
                new XmlQualifiedName("cac","urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"),
                new XmlQualifiedName("cbc","urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"),
                new XmlQualifiedName("xades","http://uri.etsi.org/01903/v1.3.2#"),
                new XmlQualifiedName("udt","urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2"),
                new XmlQualifiedName("ccts","urn:un:unece:uncefact:documentation:2"),
                new XmlQualifiedName("ubltr","urn:oasis:names:specification:ubl:schema:xsd:TurkishCustomizationExtensionComponents"),
                new XmlQualifiedName("qdt","urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2"),
                new XmlQualifiedName("ext","urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2"),
                new XmlQualifiedName("ds","http://www.w3.org/2000/09/xmldsig#"),
                new XmlQualifiedName("xsi","http://www.w3.org/2001/XMLSchema-instance"),
                new XmlQualifiedName("schemaLocation","urn:oasis:names:specification:ubl:schema:xsd:Invoice-2 UBLTR-Invoice-2.0.xsd"),
            });

        /// <summary>
        /// Takes care of namespace prefix in saved xml documents
        /// </summary>
        [System.Xml.Serialization.XmlNamespaceDeclarations()]
        public XmlSerializerNamespaces Xmlns = xmlns;

    }
}
