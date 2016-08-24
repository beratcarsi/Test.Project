using System.Collections.Generic;
using Test.EntityFramework.Core;

namespace Test.EntityFramework.Entities
{
    public class Customer : Entity
    {
        public Customer()
        {
            State = "Active";
            Orders = new List<Order>();
        }

        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string State { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

        public override string ToString()
        {
            return Name + " " + SurName + " Age: " + Age;
        }
    }
}