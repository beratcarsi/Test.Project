using System.Collections.Generic;
using Test.EntityFramework.Core;

namespace Test.EntityFramework.Entities
{
    public class Supplier : Entity
    {
        public Supplier()
        {
            Products = new List<Product>();
        }

        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}