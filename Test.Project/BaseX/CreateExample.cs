/*
 * This example shows how new databases can be created.
 *
 * Documentation: http://docs.basex.org/wiki/Clients
 *
 * (C) BaseX Team 2005-12, BSD License
 */

using System;
using System.IO;

namespace Test.Project.BaseX
{
    public static class CreateExample
    {
        public static void Create()
        {
            try
            {
                // create BasexSession
                BasexSession basexSession = new BasexSession("localhost", 1984, "admin", "admin");

                // define InputStream
                MemoryStream ms = new MemoryStream(
                  System.Text.Encoding.UTF8.GetBytes("<xml>Hello World!</xml>"));

                // create database
                basexSession.Create("database", ms);
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
