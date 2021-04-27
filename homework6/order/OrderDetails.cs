using System;
using System.Collections.Generic;
using System.Text;

namespace order
{
    public class OrderDetails
    {
        public Cargo Cargo { get; set; }
        public DateTime orderDate;
        public int SalesVolume { get; set; }
        public double TotalOrderDetailsAmount { get; }

        public OrderDetails(Cargo cargo, int salesVolume)
        {
            Cargo = cargo;
            this.orderDate = DateTime.Now;
            SalesVolume = salesVolume;
            this.TotalOrderDetailsAmount = SalesVolume * Cargo.UnitPrice;
        }

        public OrderDetails()
        {
        }

        public override string ToString()
        {
            return $"订单日期：\t{orderDate.Year}. {orderDate.Month}. {orderDate.Day}\n" +
                $"商品名：\t{Cargo.CargoName}\n" +
                $"单价：\t{Cargo.UnitPrice}\n" +
                $"数量：\t{SalesVolume}\n" +
                $"订单明细金额：\t{TotalOrderDetailsAmount}\n";
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

        public override int GetHashCode()
        {
            return HashCode.Combine(Cargo, orderDate, SalesVolume, TotalOrderDetailsAmount);
        }
    }
}
