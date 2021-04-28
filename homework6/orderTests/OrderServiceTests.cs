using Microsoft.VisualStudio.TestTools.UnitTesting;
using order;
using System;
using System.Collections.Generic;
using System.Text;

namespace order.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        private static Cargo[] cargos = { new Cargo("鱼肉", "001", 23.3), new Cargo("白菜", "002", 2.3) };
        private static Order order;
        private static Order order1;
        private static Order order2;
        [ClassInitialize]
        public static void TestClassInit(TestContext context)
        {
            order = new Order(001, new Client("张三", "1111", "武汉大学")).AddOrderDetails(new OrderDetails(cargos[0], 3))
                .AddOrderDetails(new OrderDetails(cargos[1], 4));
            order1 = new Order(002, new Client("李四", "2222", "武汉大学")).AddOrderDetails(new OrderDetails(cargos[0], 5));
            order2 = new Order(003, new Client("王五", "3333", "武汉大学")).AddOrderDetails(new OrderDetails(cargos[1], 4));
            OrderService.AddOrder(order);
            OrderService.AddOrder(order2);
        }

        [TestMethod()]
        public void ExpertTest()
        {
            Assert.IsTrue(OrderService.Expert("orders"));
        }

        [TestMethod()]
        public void ImportTest()
        {
            Assert.IsTrue(OrderService.Import("orders"));
        }

        [TestMethod()]
        public void AddOrderTest()
        {
            Assert.IsTrue(OrderService.AddOrder(order1));
        }

        [TestMethod()]
        public void DeleteOrderTest()
        {
            OrderService.DeleteOrder(002);
            Assert.IsTrue(OrderService.QueryByNumber(002)==null);
        }

        [TestMethod()]
        public void ModifyOrderTest()
        {
            OrderService.ModifyOrder(001, order => {
                order.Client.Name = "张麻子";
                order.Client.Address = "清华大学";
                order.Client.PhoneNumber = "10086";
            });
            CollectionAssert.Equals(OrderService.QueryByNumber(001),new Order(001, new Client("张麻子", "10086", "清华大学")).AddOrderDetails(new OrderDetails(cargos[0], 3))
                .AddOrderDetails(new OrderDetails(cargos[1], 4)));
        }

        [TestMethod()]
        public void QueryByNumberTest()
        {
            CollectionAssert.Equals(OrderService.QueryByNumber(002), order1);
        }

        [TestMethod()]
        public void QueryByCargoNameTest()
        {
            Assert.IsTrue(OrderService.QueryByCargoName("王五"));
        }

        [TestMethod()]
        public void QueryByClientTest()
        {
            Assert.IsTrue(OrderService.QueryByClient(new Client("李四", "2222", "武汉大学")));
        }

        [TestMethod()]
        public void SuperThanTotalTest()
        {
            Assert.IsTrue(OrderService.SuperThanTotal(10));
        }

        [TestMethod()]
        public void LowerThanTotalTest()
        {
            Assert.IsTrue(OrderService.LowerThanTotal(100));
        }
    }
}