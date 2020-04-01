using NormMVC.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace NormMVC
{
    public class DbInitializer : DropCreateDatabaseAlways<NormMVCContext>
    {
        protected override void Seed(NormMVCContext context)
        {
            IList<Product> defaultProducts = new List<Product>();

            defaultProducts.Add(new Product() { Id = 1, Name = "Mask", Price = 17, Description = "Lolol", FullDescription = "lolol1", CategoryId = 1, Category = new Category() { Id = 1, Name = "Coronavirus" } });
            defaultProducts.Add(new Product() { Id = 2, Name = "Spirt", Price = 17, Description = "Lolol", FullDescription = "lolol1", CategoryId = 1, Category = new Category() { Id = 1, Name = "Coronavirus" } });

            context.Product.AddRange(defaultProducts);

            base.Seed(context);
        }
    }
}