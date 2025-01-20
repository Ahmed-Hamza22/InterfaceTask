namespace InterfaceTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Order ID: ");
            int.TryParse(Console.ReadLine(), out int orderId);
            Console.Write("Enter Customer Name: ");
            string? customerName = Console.ReadLine();
            Console.Write("Enter Order Amount: ");
            decimal.TryParse(Console.ReadLine(), out decimal orderAmount);
            Console.Write("Enter Order Type (Online or In-Store): ");
            string? orderType = Console.ReadLine();

            Order order = new Order
            {
                OrderId = orderId,
                CustomerName = customerName,
                OrderAmount = orderAmount,
                OrderProcessor = GetOrderProcessor(orderType)
            };

            order.OrderProcessor.ProcessOrder(order);
        }

        static IOrderProcessor GetOrderProcessor(string orderType) {
            if (orderType.Equals("Online"))
                return new OnlineOrderProcessor();
            else
                return new InStoreOrderProcessor();
        }
    }
}