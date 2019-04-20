using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductSalesPoint.Model
{
    public class Sale
    {
        [Key]
        [Display(Name = "Sale Code")]
        public int Id { get; set; }

        [Display(Name = "Products List")]
        public virtual IList<SaleItem> Products { get; set; }

        [ForeignKey("PaymentId")]
        [Display(Name = "Payment Method")]
        public PaymentMethod Payment { get; set; }

        public int PaymentId { get; set; }

        public Sale()
            {
                this.Products = new List<SaleItem>();
            }

        public string ProductList()
        {
            if(Products != null && Products.Count > 0)
            {
                string names = Products[0].Product.Name;
                for (int i = 1; i < Products.Count; i++)
                {
                    string newName = Products[i].Product.Name;
                    if (!names.Contains(newName))
                    {
                        names = names + "," + Products[i].Product.Name;
                    }
                };
                return names;
            }
            return "";
        }

        public int ProductQuantity()
        {
            int totalQuantity = 0;
            if (Products != null && Products.Count > 0)
            {
                for (int i = 0; i < Products.Count; i++)
                {
                    totalQuantity += Products[i].Quantity;
                };
            }
            return totalQuantity;
        }

        public double TotalPrice()
        {
            double totalValue = 0;
            if (Products != null && Products.Count > 0)
            {
                for (int i = 0; i < Products.Count; i++)
                {
                    totalValue += Products[i].TotalPrice();
                };
            }
            return totalValue;
        }
    }
}
