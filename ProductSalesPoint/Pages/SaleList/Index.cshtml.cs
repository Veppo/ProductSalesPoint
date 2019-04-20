using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProductSalesPoint.Model;

namespace ProductSalesPoint.Pages.SaleList
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

        public IEnumerable<Sale> Sales { get; set; }

        [TempData]
        public String Message { get; set; }

        public async Task OnGet()
        {
            using (var context = new ApplicationDbContext(this.options)) {
                Sales = await context.Sale.Include(s => s.Products).ThenInclude(prod => prod.Product)
                    .Include(s => s.Payment).ToListAsync();
            }
        }
    }
}