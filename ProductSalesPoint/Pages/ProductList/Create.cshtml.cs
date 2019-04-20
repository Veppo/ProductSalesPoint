using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProductSalesPoint.Model;

namespace ProductSalesPoint.Pages.ProductList
{
    [ValidateAntiForgeryToken]
    public class CreateModel : PageModel
    {
        private DbContextOptions<ApplicationDbContext> options;

        public CreateModel()
        {
            this.options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "Sales_Point")
                .Options;
            
            //_db = db;
        }

        [BindProperty]
        public Product Product { get; set; }

        [TempData]
        public String Message { get; set; }

        public IActionResult OnGet()
        {
            using (var context = new ApplicationDbContext(this.options))
            { 
                List<Category> categories = context.Category.ToListAsync().Result;
                ViewData["Categories"] = new SelectList(categories, "Id", "Name");
            }
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            using (var context = new ApplicationDbContext(this.options))
            {
                context.Product.Add(Product);
                await context.SaveChangesAsync();
                Message = "Product Created Successfully";
                return RedirectToPage("Index");
            }
        }
    }
}