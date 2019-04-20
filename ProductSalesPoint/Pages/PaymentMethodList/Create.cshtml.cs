using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProductSalesPoint.Model;

namespace ProductSalesPoint.Pages.PaymentMethodList
{
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
        public PaymentMethod PaymentMethod { get; set; }

        [TempData]
        public String Message { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            using (var context = new ApplicationDbContext(this.options))
            {
                context.PaymentMethod.Add(PaymentMethod);
                await context.SaveChangesAsync();
                Message = "Payment Method Created Successfully";
                return RedirectToPage("Index");
            }
        }
    }
}