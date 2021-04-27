﻿using System;

namespace order
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cargo cargo1 = new Cargo("鱼肉", "001", 23.3);
            Cargo cargo2 = new Cargo("白菜", "002", 2.3);
            Cargo[] cargos = { cargo1, cargo2 };
            try
            {
                OrderService.AddOrder(new Order(001, new Client("张三", "1111", "武汉大学")).AddOrderDetails(new OrderDetails(cargos[0], 3))
                    .AddOrderDetails(new OrderDetails(cargos[1], 4)));
                OrderService.AddOrder(new Order(002, new Client("李四", "2222", "武汉大学")).AddOrderDetails(new OrderDetails(cargos[0], 5)));
                OrderService.AddOrder(new Order(003, new Client("王五", "3333", "武汉大学")).AddOrderDetails(new OrderDetails(cargos[1], 4)));

                OrderService.Expert();
                OrderService.Import();

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
