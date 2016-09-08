/*
 * This example shows how queries can be executed in an iterative manner.
 * Iterative evaluation will be slower, as more server requests are performed.
 *
 * Documentation: http://docs.basex.org/wiki/Clients
 *
 * (C) BaseX Team 2005-12, BSD License
 */

using System;
using System.IO;

namespace Test.Project.BaseX
{
    public class QueryIteratorExample
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
                    string input = "for $i in 1 to 10 return <xml>Text { $i }</xml>";
                    Query query = basexSession.Query(input);

                    // loop through all results
                    while (query.More())
                    {
                        Console.WriteLine(query.Next());
                    }

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
