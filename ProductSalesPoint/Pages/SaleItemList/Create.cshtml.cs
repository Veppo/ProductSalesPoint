using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProductSalesPoint.Model;

namespace ProductSalesPoint.Pages.SaleItemList
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
        public SaleItem SaleItem { get; set; }

        [TempData]
        public String Message { get; set; }

        public IActionResult OnGet()
        {
            using (var context = new ApplicationDbContext(this.options))
            {
                List<Product> products = context.Product.ToListAsync().Result;
                ViewData["Products"] = new SelectList(products, "Id", "Name");
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
                context.SaleItem.Add(SaleItem);
                await context.SaveChangesAsync();
                Message = "Sale Item Created Successfully";
                return RedirectToPage("Index");
            }
        }
    }
}