using System.Collections;
using System.Collections.Generic;
using Test.EntityFramework.Core;

namespace Test.EntityFramework.Entities
{
    public class Order : Entity
    {
        public Order()
        {
            OrderItems = new List<OrderItem>();
        }

        public string OrderCode { get; set; }
        public int CustomerId { get; set; }
        public decimal TotalAmount { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }

    }
}