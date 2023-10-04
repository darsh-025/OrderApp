using OrderApp;
using System;
using System.Collections.Generic;

namespace OrderApp
{
    public class Order
    {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public int Qty { get; set; }
        public double Amount { get; set; }
        public string Status { get; set; }
    }
}

namespace WebServiceConsumerApp.SpecificServiceReference
{
    public partial class SpecificServiceClient
    {
        public List<Order> GetOrders()
        {
            var orders = new List<Order>
            {
                new Order { OrderID = 123, CustomerName = "John Doe", Qty = 2, Amount = 168.00, Status = "New" },
                new Order { OrderID = 646, CustomerName = "Allen Smith", Qty = 3, Amount = 87.36, Status = "New" }
            };

            return orders;
        }
    }
}
