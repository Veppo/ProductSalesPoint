using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProductSalesPoint.Model;

namespace ProductSalesPoint.Pages.PaymentMethodList
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

        public IEnumerable<PaymentMethod> PaymentMethods { get; set; }

        [TempData]
        public String Message { get; set; }

        public async Task OnGet()
        {
            using (var context = new ApplicationDbContext(this.options)) {
                PaymentMethods = await context.PaymentMethod.ToListAsync();
            }
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            using (var context = new ApplicationDbContext(this.options))
            {
                var payment = await context.PaymentMethod.FindAsync(id);
                if (payment == null)
                {
                    return NotFound();
                }
                context.PaymentMethod.Remove(payment);
                await context.SaveChangesAsync();
                Message = "Payment Method Deleted Successfully";
                return RedirectToPage("Index");
            }
        }
    }
}