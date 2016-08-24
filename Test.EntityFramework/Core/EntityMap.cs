using System.Data.Entity.ModelConfiguration;

namespace Test.EntityFramework.Core
{
    public class EntityMap<T> : EntityTypeConfiguration<T> where T : Entity 
    {
        public EntityMap()
        {
            HasKey(x => x.Id);
            Property(x => x.CreatedOn).IsRequired();
            Property(x => x.ChangedOn);
        }
    }
}