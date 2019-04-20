using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProductSalesPoint.Model;

namespace ProductSalesPoint.Pages.CategoryList
{
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

        public IEnumerable<Category> Categories { get; set; }

        [TempData]
        public String Message { get; set; }

        public async Task OnGet()
        {
            using (var context = new ApplicationDbContext(this.options)) { 
                Categories = await context.Category.ToListAsync();
            }
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            using (var context = new ApplicationDbContext(this.options))
            {
                var category = await context.Category.FindAsync(id);
                if (category == null)
                {
                    return NotFound();
                }
                context.Category.Remove(category);
                await context.SaveChangesAsync();
                Message = "Category Deleted Successfully";
                return RedirectToPage("Index");
            }
        }
    }
}