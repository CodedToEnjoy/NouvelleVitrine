using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DAL.Concrete.EntityFramework.Contexts
{
    public class NouvelleVitrineContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=NouvelleVitrine;Trusted_Connection=true");
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Entities.Concrete.Attribute> Attributes { get; set; }
        public DbSet<ChildCategory> ChildCategories { get; set; }
        public DbSet<GrandParentCategory> GrandParentCategories { get; set; }
        public DbSet<ParentCategory> ParentCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductAttribute> ProductAttributes { get; set; }
    }
}
