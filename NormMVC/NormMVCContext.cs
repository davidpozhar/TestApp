using NormMVC.Models;
using System.Data.Entity;

namespace NormMVC
{
    public class NormMVCContext : DbContext
    {
        public NormMVCContext() : base("NormBase")
        {
            Database.SetInitializer(new DbInitializer());
        }
        public DbSet<Product> Product;

        public DbSet<Category> Category;

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Category>()
            //    .HasMany(e => e.Products)
            //    .WithRequired(e => e.Category);

            modelBuilder.Entity<Product>().ToTable("ProductInfo");
            modelBuilder.Entity<Category>().ToTable("CategoryInfo");

            modelBuilder.Entity<Product>()
                .Property(p=>p.Name)
                .IsRequired();          
        }
    }
}