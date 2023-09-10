using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartAppDemo.Model
{
    internal class LineItem
    {
        public int LineId { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }
        public LineItem(int lineId, int quantity,Product product)
        {
            LineId = lineId;
            Quantity = quantity;
            Product = product;

        }
        public double CalculateLineItemCost()
        {
            return Quantity * Product.CalculateDiscountedPrice();
        }
        public override string ToString()
        {
            string data = $"\n";
            data += "  Line Id  Product Price   Product Name  Quantity  Discount   After Discount Price \tTotal Cost";
            data += $"\n" +
                $"      {LineId}\t\t {Product.ProductPrice}\t\t{Product.ProductName} \t   {Quantity} \t      {Product.DiscountPercent}%\t\t  {Product.ToString()}\t\t  {CalculateLineItemCost()}\n";
            
            return data;
        }
    }
}
