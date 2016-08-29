using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using NUnit.Framework;
using Test.Project.Core;
using Test.Project.TestModels;

namespace Test.Project.Tests
{
    [TestFixture]
    public class ClassToTableCreatorTest
    {
        [Test]
        public void class_to_sql_table_creator_test()
        {
            List<TableClass> tables = new List<TableClass>();

            //Assembly a = Assembly.LoadFile(@"E:\Repository\EFatura\EFaturaService\EFaturaService.Core\bin\Debug\EFaturaService.Core.dll");
            Assembly a = Assembly.GetAssembly(typeof(FakeTableClass));

            Type[] types = a.GetTypes().Where(x => x.Namespace == "EFatura.Core.UBLTypes.UBLv21").ToArray();
            //Type[] types = new Type[] { new FakeDataClass().GetType() };
            //Type[] types = a.GetTypes();

            // Get Types in the assembly.
            foreach (Type t in types)
            {
                TableClass tc = new TableClass(t);
                tables.Add(tc);
            }

            // Create SQL for each table
            foreach (TableClass table in tables)
            {
                Console.WriteLine(table.CreateTableScript());
                Console.WriteLine();
            }

            // Total Hacked way to find FK relationships! Too lazy to fix right now
            foreach (TableClass table in tables)
            {
                foreach (KeyValuePair<string, Type> field in table.Fields)
                {
                    foreach (TableClass t2 in tables)
                    {
                        if (field.Value.Name == t2.ClassName)
                        {
                            // We have a FK Relationship!
                            Console.WriteLine("GO");
                            Console.WriteLine("ALTER TABLE " + table.ClassName + " WITH NOCHECK");
                            Console.WriteLine("ADD CONSTRAINT FK_" + field.Key + " FOREIGN KEY (" + field.Key + ") REFERENCES " + t2.ClassName + "(ID)");
                            Console.WriteLine("GO");

                        }
                    }
                }
            }

        }

        public static string AssemblyDirectory
        {
            get
            {
                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }

    }
}