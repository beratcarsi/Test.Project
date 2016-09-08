/*
 * This example shows how database commands can be executed.
 *
 * Documentation: http://docs.basex.org/wiki/Clients
 *
 * (C) BaseX Team 2005-12, BSD License
 */

using System;
using System.Diagnostics;
using System.IO;

namespace Test.Project.BaseX
{
    public class Example
    {
        public static void Main(string[] args)
        {
            try
            {
                // initialize timer
                Stopwatch watch = new Stopwatch();
                watch.Start();

                // create BasexSession
                BasexSession basexSession = new BasexSession("localhost", 1984, "admin", "admin");

                // version 1: perform command and print returned string
                Console.WriteLine(basexSession.Execute("info"));

                // version 2 (faster): perform command and pass on result to output stream
                Stream stream = Console.OpenStandardOutput();
                basexSession.Execute("xquery 1 to 10", stream);

                // close BasexSession
                basexSession.Close();

                // print time needed
                Console.WriteLine("\n" + watch.ElapsedMilliseconds + " ms.");
            }
            catch (IOException e)
            {
                // print exception
                Console.WriteLine(e.Message);
            }
        }
    }
}
