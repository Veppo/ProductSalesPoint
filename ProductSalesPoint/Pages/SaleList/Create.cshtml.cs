using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProductSalesPoint.Model;

namespace ProductSalesPoint.Pages.SaleList
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
        public Sale Sale { get; set; }

        [TempData]
        public String Message { get; set; }

        public IActionResult OnGet()
        {
            using (var context = new ApplicationDbContext(this.options))
            {
                List<SaleItem> itens = context.SaleItem.Where(s => s.IsSold == false)
                    .Include(s => s.Product).ToListAsync().Result;
                if (itens.Count() == 0)
                {
                    return RedirectToPage("Index");
                }
                ViewData["SaleItens"] = itens;
                ViewData["TotalValue"] = itens.Sum(x => Convert.ToInt32(x.TotalPrice())); ;

                List<PaymentMethod> payments = context.PaymentMethod.ToListAsync().Result;
                ViewData["PaymentMethods"] = new SelectList(payments, "Id", "Name");
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
                List<SaleItem> itens = context.SaleItem.Where(s => s.IsSold == false)
                    .ToListAsync().Result;
                Sale.Products = itens;
                context.Sale.Add(Sale);
                foreach (SaleItem intem in itens)
                {
                    intem.IsSold = true;
                    context.SaleItem.Update(intem);
                }
                await context.SaveChangesAsync();
                Message = "Sale Created Successfully";
                return RedirectToPage("Index");
            }
        }
    }
}