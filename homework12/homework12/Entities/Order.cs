using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Homework12.Entities
{
    [Serializable]
    public class Order : IComparable
    {
        public List<OrderDetails> OrderDetailsList { get; set; }
        public long OrderNumber { get; set; }
        public Client Client { get; set; }
        public String ClientName { get
            {
                if (Client != null) return Client.Name;
                return "";
            } }
        public DateTime orderDate { get; }
        public double TotalPrice
        {
            get
            {
                double sum = 0;
                if (OrderDetailsList == new List<OrderDetails>())
                    return 0;
                OrderDetailsList.ForEach(i => sum += i.TotalOrderDetailsAmount);
                return sum;
            }
        }

        public Order(long orderNumber, Client client)
        {
            OrderDetailsList = new List<OrderDetails>();
            OrderNumber = orderNumber;
            Client = client;
            this.orderDate = DateTime.Now;
        }

        public Order()
        {
            OrderDetailsList = new List<OrderDetails>();
            this.orderDate = DateTime.Now;
        }

        public Order AddOrderDetails(OrderDetails orderDetails)
        {

            if (OrderDetailsList.Exists(o => o.Cargo == orderDetails.Cargo))
            {
                throw new ArgumentException("该订单明细已存在");
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
            return $"订单日期：\t{orderDate.Year}. {orderDate.Month}. {orderDate.Day}\n" + 
                $"__订单号：\t{OrderNumber}\n" +
                $"{Client.ToString()}\n" +
                str.ToString();
        }

        public override bool Equals(Object obj)
        {
            Order order = obj as Order;
            if (order != null)
            {
                return this.OrderNumber == order.OrderNumber;
            }
            return false;
        }

        public bool DeleteOrderDetails(Cargo cargo)
        {
            if (OrderDetailsList.Where(o => o.Cargo == cargo).FirstOrDefault() != null)
            {
                OrderDetailsList.Remove(OrderDetailsList.Where(o => o.Cargo == cargo).FirstOrDefault());
                Console.WriteLine("已删除！");
                return true;
            }
            return false;
        }

        public int CompareTo(object obj)
        {
            Order order = obj as Order;
            return (int)(this.OrderNumber - order.OrderNumber);
        }
        public override int GetHashCode()
        {
            int hashCode = 1491198517;
            hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderDetails>>.Default.GetHashCode(OrderDetailsList);
            hashCode = hashCode * -1521134295 + OrderNumber.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Client>.Default.GetHashCode(Client);
            hashCode = hashCode * -1521134295 + TotalPrice.GetHashCode();
            return hashCode;
        }
    }
}
