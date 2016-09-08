using System;
using System.IO;
using System.Text;
using NUnit.Framework;
using Test.Project.BaseX;

namespace Test.Project.Tests
{
    [TestFixture]
    public class BasexTest
    {
        [Test]
        public void basex_create_db_tests()
        {
            try
            {
                // create BasexSession
                BasexSession basexSession = new BasexSession("localhost", 1984, "admin", "admin");

                // define InputStream
                var stream = new MemoryStream(Encoding.UTF8.GetBytes("<xml>Hello World!</xml>"));
                
                //var baseDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent?.FullName;
                //var stream = new FileStream(baseDirectory + "/Basex/Files/factbook.xml", FileMode.Open);

                // create database
                basexSession.Create("database", stream);
                Console.WriteLine(basexSession.Info);

                // run query on database

                // for $country in db:open('factbook')//country
                // where $country / @population > 100000000
                // for $city in $country//city[population > 1000000]
                // group by $name := $country / name[1]
                // count $id
                // return < country id = '{ $id }' name = '{ $name }' >{ $city / name }</ country >
                
                //Console.WriteLine(basexSession.Execute("xquery /"));
                Console.WriteLine(basexSession.Execute(@"xquery //name"));

                // drop database
                basexSession.Execute("drop db database");

                // close BasexSession
                basexSession.Close();
            }
            catch (IOException e)
            {
                // print exception
                Console.WriteLine(e.Message);
            }

        }

    }
}