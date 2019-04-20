using System;
using System.ComponentModel.DataAnnotations;

namespace ProductSalesPoint.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Category Name")]
        public String Name { get; set; }

        public String Description { get; set; }

    }
}
