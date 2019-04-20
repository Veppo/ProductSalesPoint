using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProductSalesPoint.Model;

namespace ProductSalesPoint.Pages.SaleItemList
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

        public IEnumerable<SaleItem> SaleItems { get; set; }

        [TempData]
        public String Message { get; set; }

        public async Task OnGet()
        {
            using (var context = new ApplicationDbContext(this.options)) {
                SaleItems = await context.SaleItem.Where(s => s.IsSold == false)
                    .Include(s => s.Product).ToListAsync();
            }
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            using (var context = new ApplicationDbContext(this.options))
            {
                var sale = await context.SaleItem.FindAsync(id);
                if (sale == null)
                {
                    return NotFound();
                }
                context.SaleItem.Remove(sale);
                await context.SaveChangesAsync();
                Message = "Sale Item Deleted Successfully";
                return RedirectToPage("Index");
            }
        }
    }
}