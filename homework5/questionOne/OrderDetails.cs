using System;
using System.Collections.Generic;
using System.Text;

namespace questionOne
{
    class OrderDetails
    {
        public Cargo Cargo { get; set; }
        public DateTime orderDate;
        public int SalesVolume { get; set; }
        private double totalOrderDetailsAmount;

        public double getTotalDetailsAmount()
        {
            return totalOrderDetailsAmount;
        }

        public OrderDetails(Cargo cargo, int salesVolume)
        {
            Cargo = cargo;
            this.orderDate = DateTime.Now;
            SalesVolume = salesVolume;
            this.totalOrderDetailsAmount = SalesVolume * Cargo.UnitPrice;
        }
        public override string ToString()
        {
            return $"订单日期：\t{orderDate.Year}. {orderDate.Month}. {orderDate.Day}\n" +
                $"商品名：\t{Cargo.CargoName}\n" +
                $"单价：\t{Cargo.UnitPrice}\n" +
                $"数量：\t{SalesVolume}\n" +
                $"订单明细金额：\t{totalOrderDetailsAmount}\n";
        }

        public override bool Equals(Object obj)
        {
            OrderDetails orderDetails = obj as OrderDetails;
            if (this.Cargo.Equals(orderDetails.Cargo))
            {
                if (this.SalesVolume == orderDetails.SalesVolume)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
