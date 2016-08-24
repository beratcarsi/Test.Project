using Test.EntityFramework.Core;
using Test.EntityFramework.Entities;

namespace Test.EntityFramework.Mappings
{
    public class ProductMap : EntityMap<Product>
    {
        public ProductMap()
        {
            Property(x => x.ProductName).HasMaxLength(200);
            Property(x => x.UnitPrice);
            Property(x => x.Package).HasMaxLength(20);

            HasRequired(x => x.Supplier).WithMany(x => x.Products).HasForeignKey(x => x.SuplierId);
        }

    }
}