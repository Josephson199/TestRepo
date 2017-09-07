using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiagnosticTestAspNet2Project.Models;

namespace DiagnosticTestAspNet2Project.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            var tv = new ProductCategory
            {
                Name = "TV",
                ProductCategoryId = 1
            };
            var dvd = new ProductCategory
            {
                Name = "DVD",
                ProductCategoryId = 2
            };
            var vhs = new ProductCategory
            {
                Name = "VHS",
                ProductCategoryId = 3
            };
            var productCategories = new List<ProductCategory> { tv, dvd, vhs };

            context.AddRange(productCategories);
            context.SaveChanges();
        }
    }
}