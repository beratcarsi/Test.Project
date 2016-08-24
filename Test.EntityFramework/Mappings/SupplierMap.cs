using Test.EntityFramework.Core;
using Test.EntityFramework.Entities;

namespace Test.EntityFramework.Mappings
{
    public class SupplierMap : EntityMap<Supplier>
    {
        public SupplierMap()
        {
            Property(x => x.CompanyName);
            Property(x => x.ContactName);
            Property(x => x.ContactTitle);
            Property(x => x.Email);
            Property(x => x.Phone);
        }
    }
}