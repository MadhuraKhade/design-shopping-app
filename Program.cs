using ShoppingCartAppDemo.Model;

namespace ShoppingCartAppDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Order> orders = new List<Order> {
                new Order(101,DateTime.Now,new List<LineItem>
                {
                    new LineItem(1, 2, new Product(111, "Milk", 60, 10)),
                    new LineItem(2, 12, new Product(121, "Egg", 7, 5))

                }),
                new Order(102,DateTime.Now,new List<LineItem>
                {
                    new LineItem(1, 1, new Product(211, "Rice", 200, 15)),
                    new LineItem(2,5,new Product(221,"Bread",50,5))
                })
            };
            Customer customer = new Customer(1, "Allen",orders);
            Console.WriteLine(customer.GetDetails());
        }
    }
}