using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProductSalesPoint.Model;

namespace ProductSalesPoint.Pages.ProductList
{
    [ValidateAntiForgeryToken]
    public class IndexModel : PageModel
    {

        private DbContextOptions<ApplicationDbContext> options;

        public IndexModel()
        {
            this.options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "Sales_Point")
                .Options;
            
            //_db = db;
        }

        public IEnumerable<Product> Products { get; set; }

        [TempData]
        public String Message { get; set; }

        public async Task OnGet()
        {
            using (var context = new ApplicationDbContext(this.options)) {
                Products = await context.Product.Include(p => p.Category).ToListAsync();
            }
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            using (var context = new ApplicationDbContext(this.options))
            {
                var product = await context.Product.FindAsync(id);
                if (product == null)
                {
                    return NotFound();
                }
                context.Product.Remove(product);
                await context.SaveChangesAsync();
                Message = "Product Deleted Successfully";
                return RedirectToPage("Index");
            }
        }
    }
}