using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartAppDemo.Model
{
    internal class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        List<LineItem> LineItems { get; set; }
        public Order(int orderId,DateTime orderDate,List<LineItem> lineList)
        {
            OrderId = orderId;
            OrderDate = orderDate;
            LineItems = lineList;
        }
        public double CalculateOrderPrice()
        {
            double totalOrderPrice = 0;
            foreach (LineItem lineItem in LineItems)
            {
                totalOrderPrice += lineItem.CalculateLineItemCost();
            }
            return totalOrderPrice;
        }
        public override string ToString()
        {

            string data =
                $"\nOrder Id: {OrderId}\n" +
                $"Order Date: {OrderDate}\n";
            foreach(LineItem lineItem in LineItems)
            {
                data += lineItem.ToString() ;
            }
            data += "---------------------------------------------------------------------------------------------------------";
            data += $"\n \t \t \t \t\t\t\t\t\tTotal Order Cost: {CalculateOrderPrice()}\n";
            return data;  
        }

    }
}
