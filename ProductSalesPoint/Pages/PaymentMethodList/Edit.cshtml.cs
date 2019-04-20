using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProductSalesPoint.Model;

namespace ProductSalesPoint.Pages.PaymentMethodList
{
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
        public PaymentMethod PaymentMethod { get; set; }

        [TempData]
        public String Message { get; set; }

        public void OnGet(int id)
        {
            using (var context = new ApplicationDbContext(this.options))
            {
                PaymentMethod = context.PaymentMethod.Find(id);
            }
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                using (var context = new ApplicationDbContext(this.options))
                {
                    var CategoryFromDb = context.Category.Find(PaymentMethod.Id);
                    CategoryFromDb.Name = PaymentMethod.Name;
                    CategoryFromDb.Description = PaymentMethod.Description;

                    await context.SaveChangesAsync();
                    Message = "Payment Method has been Updated Successfully";
                    return RedirectToPage("Index");
                }
            }

            return RedirectToPage();
        }
    }
}