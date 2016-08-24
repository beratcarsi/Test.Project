using Test.EntityFramework.Core;

namespace Test.EntityFramework.Entities
{
    public class OrderItem : Entity
    {
        public int OrderId { get; set; }
        public decimal UnitPrice { get; set; }
        public int  Quantity { get; set; }

        public virtual Order Order { get; set; }
    }
}