using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProductSalesPoint.Model;

namespace ProductSalesPoint.Pages.SaleItemList
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
        public SaleItem SaleItem { get; set; }

        [TempData]
        public String Message { get; set; }

        public void OnGet(int id)
        {
            using (var context = new ApplicationDbContext(this.options))
            {
                SaleItem = context.SaleItem.Find(id);
                
                List<Product> products = context.Product.ToListAsync().Result;
                ViewData["Products"] = new SelectList(products, "Id", "Name");
            }
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                using (var context = new ApplicationDbContext(this.options))
                {
                    var SaleItemFromDb = context.SaleItem.Find(SaleItem.Id);
                    SaleItemFromDb.ProductId = SaleItem.ProductId;
                    SaleItemFromDb.Quantity = SaleItem.Quantity;
                    SaleItemFromDb.Product = SaleItem.Product;

                    await context.SaveChangesAsync();
                    Message = "Sale Item has been Updated Successfully";
                    return RedirectToPage("Index");
                }
            }

            return RedirectToPage();
        }
    }
}