using System.Linq;
using DiagnosticTestAspNet2Project.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DiagnosticTestAspNet2Project.Services
{
    public class ProductCategoryService
    {
        private readonly ApplicationDbContext _context;

        public ProductCategoryService(ApplicationDbContext context)
        {
            _context = context;
        }
        public SelectList GetSelectList()
        {
            return new SelectList(_context.ProductCategories.Select(x => new { Id = x.ProductCategoryId, Value = x.Name }),
                "Id", "Value");
        }
    }
}
