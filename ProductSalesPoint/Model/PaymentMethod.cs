using System;
using System.ComponentModel.DataAnnotations;

namespace ProductSalesPoint.Model
{
    public class PaymentMethod
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Payment Method")]
        public String Name { get; set; }

        public String Description { get; set; }
    }
}
