using Test.EntityFramework.Core;
using Test.EntityFramework.Entities;

namespace Test.EntityFramework.Mappings
{
    public class OrderMap : EntityMap<Order>
    {
        public OrderMap()
        {
            Property(x => x.OrderCode).HasMaxLength(20);
            Property(x => x.TotalAmount).IsRequired();

            HasRequired(x => x.Customer).WithMany(x => x.Orders).HasForeignKey(x => x.CustomerId);
        }
    }
}