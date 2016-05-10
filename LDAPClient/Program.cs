using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDAPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var entry = new DirectoryEntry("LDAP://192.168.1.23", "test@elpo.local", "qwerty");
            var search = new DirectorySearcher(entry);
            Console.WriteLine(search.FindOne().GetDirectoryEntry().Username);
            var one = search.FindOne().Properties;


            search.Filter = "(objectCategory=user)"; // sadece kullanıcılar
            string[] properties = { "fullname", "cn", "department", "samaccountname" }; //istenilen alanlar

            search.PropertiesToLoad.AddRange(properties);
            foreach (SearchResult adObj in search.FindAll())
            {
                //string cn = AdObj.GetDirectoryEntry().Properties["cn"].Value.ToString();      
                foreach (object p in adObj.Properties.PropertyNames)
                {
                    Console.WriteLine(p + ":::" + adObj.Properties[p.ToString()][0]);
                }
            }
            Console.ReadKey();


            //berat@elpo.local > 123123
            //  samaccountname:::berat
            //  adspath:::LDAP://192.168.1.23/CN=berat carsi,CN=Users,DC=elpo,DC=local
            //  cn:::berat carsi

            if (args.Length != 4)
            {
                Console.WriteLine("Usage: LDAPClient <username> <domain> <password> <LDAP server URL>");
                Environment.Exit(1);
            }

            var client = new Client("berat@elpo.local", "elpo.local", "123123", "192.168.1.23");

            var pass = client.validateUser("berat@elpo.local", "123123");
            Console.WriteLine("VALIDATION USER !!! pass: " + pass);

            try
            {
                //Adding a user
                client.addUser(new UserModel("uid=sampleuser,ou=users,dc=example,dc=com",
                    "sampleuser", "users", "plaintextpass"));
            }
            catch (Exception e)
            {
                //The user may already exist
                Console.WriteLine(e);
            }

            //Searching for all users
            var searchResult = client.search("ou=users,dc=example,dc=com", "objectClass=*");
            foreach (Dictionary<string, string> d in searchResult)
            {
                Console.WriteLine(String.Join("\r\n", d.Select(x => x.Key + ": " + x.Value).ToArray()));
            }

            //Validating credentials
            if (client.validateUser("sampleuser", "plaintextpass"))
            {
                Console.WriteLine("Valid credentials");
            }
            else
            {
                Console.WriteLine("Invalid credentials");
            }

            //Validating credentials using LDAP bind
            //For this to work the server must be configured to map users correctly to its internal database
            if (client.validateUserByBind("sampleuser", "plaintextpass"))
            {
                Console.WriteLine("Valid credentials (bind)");
            }
            else
            {
                Console.WriteLine("Invalid credentials (bind)");
            }

            //Modifying a user
            client.changeUserUid("sampleuser", "newsampleuser");

            //Deleting a user
            client.delete("uid=newsampleuser,ou=users,dc=example,dc=com");
        }
    }
}
