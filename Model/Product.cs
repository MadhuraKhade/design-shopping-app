using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartAppDemo.Model
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }  
        public double DiscountPercent { get; set; }
        public Product(int productId, string productName, double productPrice, double discountPercent)
        {
            ProductId = productId;
            ProductName = productName;
            ProductPrice = productPrice;
            DiscountPercent = discountPercent;
        }
        public double CalculateDiscountedPrice()
        {
            double unitCostAfterDiscount = ProductPrice - (DiscountPercent/100);
            return unitCostAfterDiscount;
        }
        public override string ToString()
        {
             return $"{CalculateDiscountedPrice()}";
        }
    }
}
