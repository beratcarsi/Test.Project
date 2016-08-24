using Test.EntityFramework.Core;

namespace Test.EntityFramework.Entities
{
    public class Product : Entity
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public string Package { get; set; }
        public int  SuplierId { get; set; }
        public virtual Supplier Supplier { get; set; }

    }
}