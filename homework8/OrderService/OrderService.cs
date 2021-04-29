using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Xml.Serialization;
using System.IO;

namespace OrderService
{
    public class OrderService
    {
        public static List<Order> orderList = new List<Order>();


        public static bool Expert(string xmlName)
        {
            Order[] orders = orderList.ToArray();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Order[]));
            using(FileStream fs = new FileStream(xmlName+".xml", FileMode.Create))
            {
                if (fs==null) return false;
                xmlSerializer.Serialize(fs, orders);
                Console.WriteLine("<-------序列化文件------->");
                Console.WriteLine(File.ReadAllText("order.xml") + "\n");
                return true;
            }
        }

        public static bool Import(string xmlName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Order[]));
            using (FileStream fs = new FileStream(xmlName+".xml", FileMode.Open))
            {
                Order[] orders1 = (Order[])xmlSerializer.Deserialize(fs);
                if (orders1 == null)
                    return false;
                Console.WriteLine("<-------反序列化文件------->");
                Array.ForEach(orders1, order => Console.WriteLine(order));
                return true;
            }
        }

        //下方是第五次作业代码
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
            if (orderList.Where(o => o.OrderNumber == orderNumber).FirstOrDefault() != null)
            {
                orderList.Remove(orderList.Where(o => o.OrderNumber == orderNumber).FirstOrDefault());
                Console.WriteLine("已删除！");
                return true;
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

        public static Order QueryByNumber(long orderNumber)
        {
            var query = from s in orderList
                        where s.OrderNumber == orderNumber
                        select s;
            if (query.ToList().Count != 0)
            {
                Console.WriteLine(query.ToList()[0].ToString());
            }
            else
            {
                Console.WriteLine("未找到订单！");
                return null;
            }
            return query.ToList()[0];
        }

        public static List<Order> QueryByCargoName(String cargoName)
        {
            var query = from order in orderList
                        where order.OrderDetailsList.Any(x => {
                            if (x.Cargo.CargoName == cargoName)
                                return true;
                            return false;
                        })
                        orderby order.OrderNumber
                        select order;
            if (query.ToList().Count!=0)
            {
                foreach (var q in query)
                {
                    Console.WriteLine(q.ToString());
                }
            }
            else
            {
                Console.WriteLine("未找到订单！");
                return null;
            }
            return query.ToList();

        }

        public static List<Order> QueryByClientName(String clientName)
        {
            var query = from order in orderList
                        where order.ClientName ==clientName
                        orderby order.OrderNumber
                        select order;
            if (query.ToList().Count != 0)
            {
                foreach (var q in query)
                {
                    Console.WriteLine(q.ToString());
                }
            }
            else
            {
                Console.WriteLine("未找到订单！");
                return null;
            }
            return query.ToList();

        }

        public static List<Order> QueryByClient(Client client)
        {
            var query = orderList.Where(order => order.Client.Equals(client))
                .OrderBy(order => order.OrderNumber)
                .Select(order => order);
            if (query.ToList().Count != 0)
            {
                foreach (var q in query)
                {
                    Console.WriteLine(q.ToString());
                }
            }
            else return null;
            return query.ToList();
        }

        public static List<Order> SuperThanTotal(double total)
        {
            var query = orderList
                .Where(order => order.TotalPrice >= total)
                .OrderBy(order => order.OrderNumber)
                .Select(order => order);
            if (query.ToList().Count != 0)
            {
                foreach (var q in query)
                {
                    Console.WriteLine(q.ToString());
                }
            }
            else return null;
            return query.ToList();
        }

        public static List<Order> LowerThanTotal(double total)
        {
            var query = orderList
                .Where(order => order.TotalPrice <= total)
                .OrderBy(order => order.OrderNumber)
                .Select(order => order);
            if (query.ToList().Count != 0)
            {
                foreach (var q in query)
                {
                    Console.WriteLine(q.ToString());
                }
            }
            else return null;
            return query.ToList();
        }


    }
}
