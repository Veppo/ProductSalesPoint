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
        public Category Category { get; set; }

        [TempData]
        public String Message { get; set; }

        public void OnGet(int id)
        {
            using (var context = new ApplicationDbContext(this.options))
            {
                Category = context.Category.Find(id);
            }
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                using (var context = new ApplicationDbContext(this.options))
                {
                    var CategoryFromDb = context.Category.Find(Category.Id);
                    CategoryFromDb.Name = Category.Name;
                    CategoryFromDb.Description = Category.Description;

                    await context.SaveChangesAsync();
                    Message = "Category has been Updated Successfully";
                    return RedirectToPage("Index");
                }
            }

            return RedirectToPage();
        }
    }
}