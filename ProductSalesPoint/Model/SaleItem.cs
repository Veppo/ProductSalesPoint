using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductSalesPoint.Model
{
    public class SaleItem
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        [Range(1, 200)]
        public int Quantity { get; set; }

        public Boolean IsSold { get; set; } = false;

        public double TotalPrice()
        {
            return Quantity * Product.Price;
        }

    }
}
