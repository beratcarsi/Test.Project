using Test.EntityFramework.Core;
using Test.EntityFramework.Entities;

namespace Test.EntityFramework.Mappings
{
    public class CustomerMap : EntityMap<Customer>
    {
        public CustomerMap()
        {
            // ToTable("CustomerTable");
            Property(x => x.Name).HasMaxLength(100);
            Property(x => x.SurName).HasMaxLength(100);
            Property(x => x.Age);
            Property(x => x.Email);
            Property(x => x.Phone);
            Property(x => x.State).IsRequired();
        }
    }
}