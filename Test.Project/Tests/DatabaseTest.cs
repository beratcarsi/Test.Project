using System;
using NUnit.Framework;
using Test.EntityFramework.Core;
using Test.EntityFramework.Entities;

namespace Test.Project.Tests
{
    public class DatabaseTest
    {
        // link: https://msdn.microsoft.com/en-us/data/jj193542.aspx

        [Test]
        public void ef_database_creator_test()
        {
            using (var context = new MyDatabaseContext())
            {
                var customer = new Customer()
                {
                    Name = "Berat",
                    SurName = "Carsi",
                    CreatedOn = DateTime.Now
                };

                context.Customers.Add(customer);
                context.SaveChanges();

                foreach (var item in context.Customers)
                {
                    Console.WriteLine(item.Name);
                }
            }

        }

    }
}