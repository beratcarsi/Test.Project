using System;

namespace Test.EntityFramework.Core
{
    public class Entity : Entity<int> { }

    public class Entity<TId>
    {
        public TId Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ChangedOn { get; set; }
    }
}