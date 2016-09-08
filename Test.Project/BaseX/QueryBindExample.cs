/*
 * This example shows how external variables can be bound to XQuery expressions.
 *
 * Documentation: http://docs.basex.org/wiki/Clients
 *
 * (C) BaseX Team 2005-12, BSD License
 */

using System;
using System.IO;

namespace Test.Project.BaseX
{
    public class QueryBindExample
    {
        public static void Main(string[] args)
        {
            try
            {
                // create BasexSession
                BasexSession basexSession = new BasexSession("localhost", 1984, "admin", "admin");

                try
                {
                    // create query instance
                    string input = "declare variable $name external;" +
                        "for $i in 1 to 10 return element { $name } { $i }";

                    Query query = basexSession.Query(input);

                    // bind variable
                    query.Bind("$name", "number");

                    // print result
                    Console.WriteLine(query.Execute());

                    // close query
                    query.Close();
                }
                catch (IOException e)
                {
                    // print exception
                    Console.WriteLine(e.Message);
                }

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
