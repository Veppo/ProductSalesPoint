using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProductSalesPoint.Model;

namespace ProductSalesPoint.Pages.CategoryList
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
        public Category Category { get; set; }

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
                context.Category.Add(Category);
                await context.SaveChangesAsync();
                Message = "Category Created Successfully";
                return RedirectToPage("Index");
            }
        }
    }
}