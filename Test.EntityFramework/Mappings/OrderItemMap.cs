using Test.EntityFramework.Core;
using Test.EntityFramework.Entities;

namespace Test.EntityFramework.Mappings
{
    public class OrderItemMap : EntityMap<OrderItem>
    {
        public OrderItemMap()
        {
            Property(x => x.UnitPrice);
            Property(x => x.Quantity);

            HasRequired(x => x.Order).WithMany(x => x.OrderItems).HasForeignKey(x => x.OrderId);
        }
    }
}