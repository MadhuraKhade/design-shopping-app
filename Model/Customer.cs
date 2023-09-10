using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartAppDemo.Model
{
    internal class Customer
    {

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        List<Order> Orders { get; set; }
        public Customer(int customerId, string customerName,List<Order>orders)
        {
            CustomerId = customerId;
            CustomerName = customerName;
            Orders = orders;
        }

        public override string ToString()
        {
            return $"Customer Id: {CustomerId}\n" +
                $"Customer Name: {CustomerName}\n" +
                $"Order Count: {Orders.Count}\n";
        }
        public string GetDetails()
        {
            int orderNumber = 1;
            string data = "";
            data += ToString();
            foreach (var item in Orders)
            {
                data += $"\nOrder No.: {orderNumber++}";
                data += item.ToString();
            }
            
            
            return data ;
        }
    }
}
