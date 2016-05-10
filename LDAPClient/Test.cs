using System;
using System.DirectoryServices;
using NUnit.Framework;
using Shouldly;

namespace LDAPClient
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void connect_test()
        {
            //  berat@elpo.local > 123123
            //  samaccountname:::berat
            //  adspath:::LDAP://192.168.1.23/CN=berat carsi,CN=Users,DC=elpo,DC=local
            //  cn:::berat carsi
            
            var entry = new DirectoryEntry("LDAP://192.168.1.23", "berat@elpo.local", "123123");
            var search = new DirectorySearcher(entry);

            
            var username = search.FindOne().GetDirectoryEntry().Username;
            username.ShouldBe("berat@elpo.local");

            Console.WriteLine(username);

            Console.WriteLine(search.FindOne().GetDirectoryEntry().Properties);

            Console.WriteLine(search.FindOne().Properties["samaccountname"].ToString());
            

            var one = search.FindOne().Properties;
            Console.WriteLine(one);
        }
         
    }
}