using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace questionOne
{
    class Order
    {
        public List<OrderDetails> OrderDetailsList { get; set; }
        public long OrderNumber { get; set; }
        public Client Client { get; set; }
        private double TotalPrice;

        public Order(long orderNumber, Client client)
        {
            OrderDetailsList = new List<OrderDetails>();
            OrderNumber = orderNumber;
            Client = client;
        }

        public double getTotalPrice()
        {
            TotalPrice = 0;
            OrderDetailsList.ForEach(orderDetails => TotalPrice += orderDetails.getTotalDetailsAmount());
            return TotalPrice;
        }
        public Order AddOrderDetails(OrderDetails orderDetails)
        {

            if (OrderDetailsList.Count != 0)
            {
                if (OrderDetailsList.Exists(o => o.Equals(orderDetails)))
                {
                    throw new ArgumentException("该订单明细已存在");
                }
            }
            OrderDetailsList.Add(orderDetails);
            return this;
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            foreach(OrderDetails x in OrderDetailsList)
            {
                str.Append(x.ToString());
            }
            return $"__订单号：\t{OrderNumber}\n" +
                $"{Client.ToString()}\n" +
                str.ToString();
        }

        public override bool Equals(Object obj)
        {
            Order order = obj as Order;
            return this.OrderNumber == order.OrderNumber;
        }

        public bool isOnly()
        {
            return this.OrderDetailsList.GroupBy(orderDetails => orderDetails).Where(g => g.Count() > 1).Count() <= 0;
        }
    }
}
