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
    public class EditModel : PageModel
    {
        private DbContextOptions<ApplicationDbContext> options;

        public EditModel()
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

        public void OnGet(int id)
        {
            using (var context = new ApplicationDbContext(this.options))
            {
                Product = context.Product.Find(id);
                
                List<Category> cats = context.Category.ToListAsync().Result;
                ViewData["Categories"] = new SelectList(cats, "Id", "Name");
            }
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                using (var context = new ApplicationDbContext(this.options))
                {
                    var ProductFromDb = context.Product.Find(Product.Id);
                    ProductFromDb.Name = Product.Name;
                    ProductFromDb.CategoryId = Product.CategoryId;
                    ProductFromDb.Price = Product.Price;

                    await context.SaveChangesAsync();
                    Message = "Product has been Updated Successfully";
                    return RedirectToPage("Index");
                }
            }

            return RedirectToPage();
        }
    }
}