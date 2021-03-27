using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace questionOne
{
    class OrderService
    {
        private static List<Order> orderList = new List<Order>();

        public static bool AddOrder(Order order)
        {
            if (orderList.Count != 0)
            {
                if (orderList.Exists(o => o.Equals(order)))
                {
                    throw new ArgumentException("请勿添加重复订单");
                }
            }
            orderList.Add(order);
            return true;
        }

        public static bool DeleteOrder(long orderNumber)
        {
            foreach (Order order in orderList)
            {
                if (order.OrderNumber == orderNumber)
                {
                    orderList.Remove(order);
                    Console.WriteLine("已删除！");
                    return true;
                }
            }
            return false;
        }

        public static bool ModifyOrder(long orderNumber, Action<Order> modifyOperation)
        {
            foreach (Order order in orderList)
            {
                if (order.OrderNumber == orderNumber)
                {
                    modifyOperation(order);
                    Console.WriteLine("已修改！");
                    return true;
                }
                else
                {
                    throw new ArgumentException("未找到需要修改的订单！");
                }
            }
            return false;
        }

        public static void QueryByNumber(long orderNumber)
        {
            var query = from s in orderList
                        where s.OrderNumber == orderNumber
                        select s;
            if (query.ToList().Count != 0)
            {
                Console.WriteLine(query.ToList()[0].ToString());
            }
            else Console.WriteLine("未找到订单！");
        }

        public static void QueryByCargoName(String cargoName)
        {
            var query = from order in orderList
                        where order.OrderDetailsList.Any(x => {
                            if (x.Cargo.CargoName == cargoName)
                                return true;
                            return false;
                        })
                        orderby order.OrderNumber
                        select order;
            foreach(var q in query)
            {
                Console.WriteLine(q.ToString());
            }
        }

        public static void QueryByClient(Client client)
        {
            var quert = orderList.Where(order => order.Client.Equals(client))
                .OrderBy(order => order.OrderNumber)
                .Select(order => order);
            foreach(var q in quert)
            {
                Console.WriteLine(q.ToString());
            }
        }

        public static void SuperThanTotal(double total)
        {
            var quert = orderList
                .Where(order => order.getTotalPrice() >= total)
                .OrderBy(order => order.OrderNumber)
                .Select(order => order);
            foreach (var q in quert)
            {
                Console.WriteLine(q.ToString());
            }
        }

        public static void LowerThanTotal(double total)
        {
            var quert = orderList
                .Where(order => order.getTotalPrice() <= total)
                .OrderBy(order => order.OrderNumber)
                .Select(order => order);
            foreach (var q in quert)
            {
                Console.WriteLine(q.ToString());
            }
        }
    }
}
