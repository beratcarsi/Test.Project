using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using NUnit.Framework;
using Test.Project.Core;

namespace Test.Project.Tests
{
    [TestFixture]
    public class XmlTest
    {
        private readonly string _baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

        [Test]
        public void xsd_validation_test()
        {
            string xsdMarkup =
                    @"<xsd:schema xmlns:xsd='http://www.w3.org/2001/XMLSchema'>
                       <xsd:element name='Root'>
                        <xsd:complexType>
                         <xsd:sequence>
                          <xsd:element name='Child1' minOccurs='1' maxOccurs='1'/>
                          <xsd:element name='Child2' minOccurs='1' maxOccurs='1'/>
                         </xsd:sequence>
                        </xsd:complexType>
                       </xsd:element>
                      </xsd:schema>";

            var schemas = new XmlSchemaSet();
            schemas.Add("", XmlReader.Create(new StringReader(xsdMarkup)));

            var doc1 = new XDocument(
                new XElement("Root",
                    new XElement("Child1", "content1"),
                    new XElement("Child2", "content1")
                )
            );

            var doc2 = new XDocument(
                new XElement("Root",
                    new XElement("Child1", "content1"),
                    new XElement("Child3", "content1")
                )
            );

            Console.WriteLine("Validating doc1");
            bool errors = false;
            doc1.Validate(schemas, (o, e) =>
            {
                Console.WriteLine("{0}", e.Message);
                errors = true;
            });
            Console.WriteLine("doc1 {0}", errors ? "did not validate" : "validated");

            Console.WriteLine();
            Console.WriteLine("Validating doc2");
            errors = false;
            doc2.Validate(schemas, (o, e) =>
            {
                Console.WriteLine("{0}", e.Message);
                errors = true;
            });
            Console.WriteLine("doc2 {0}", errors ? "did not validate" : "validated");
        }

    }
}