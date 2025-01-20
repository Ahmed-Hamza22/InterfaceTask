using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask
{
    public class OnlineOrderProcessor : IOrderProcessor
    {
        public void ProcessOrder(Order order)
        {
            decimal discount = CalculateDiscount(order.OrderAmount);
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Order {order.OrderId} processed for {order.CustomerName}. Final amount after 10% discount: ${discount}");
        }
        public decimal CalculateDiscount(decimal orderAmount)
        {
            return orderAmount * 0.90M;
        }
    }
}
