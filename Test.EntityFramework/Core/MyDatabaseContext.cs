using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;
using Test.EntityFramework.Entities;
using Test.EntityFramework.Mappings;
using static System.String;

namespace Test.EntityFramework.Core
{
    public class MyDatabaseContext : DbContext
    {
        public MyDatabaseContext() : base(@"Data Source=.;Initial Catalog=MyData;Integrated Security=SSPI") // name="DefaultConnection"
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
            //    .Where(type => !IsNullOrEmpty(type.Namespace))
            //    .Where(
            //        type =>
            //            type.BaseType != null && type.BaseType.IsGenericType &&
            //            type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));

            //foreach (var configurationInstance in typesToRegister.Select(Activator.CreateInstance))
            //{
            //    modelBuilder.Configurations.Add((dynamic)configurationInstance);
            //}

            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new OrderItemMap());
            modelBuilder.Configurations.Add(new SupplierMap());

            base.OnModelCreating(modelBuilder);
        }

    }
}