/*
 * This example shows how new documents can be added.
 *
 * Documentation: http://docs.basex.org/wiki/Clients
 *
 * (C) BaseX Team 2005-12, BSD License
 */

using System;
using System.IO;

namespace Test.Project.BaseX
{
    public class AddExample
    {
        public static void Main(string[] args)
        {
            try
            {
                // create BasexSession
                BasexSession basexSession = new BasexSession("localhost", 1984, "admin", "admin");

                // create empty database
                basexSession.Execute("create db database");
                Console.WriteLine(basexSession.Info);

                // define InputStream
                MemoryStream ms = new MemoryStream(
                  System.Text.Encoding.UTF8.GetBytes("<xml>Hello World!</xml>"));

                // add document
                basexSession.Add("world/world.xml", ms);
                Console.WriteLine(basexSession.Info);

                // define InputStream
                ms = new MemoryStream(
                  System.Text.Encoding.UTF8.GetBytes("<xml>Hello Universe!</xml>"));

                // add document
                basexSession.Add("Universe.xml", ms);
                Console.WriteLine(basexSession.Info);

                // run query on database
                Console.WriteLine(basexSession.Execute("xquery /"));

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
