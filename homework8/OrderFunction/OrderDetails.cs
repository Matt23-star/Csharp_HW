using System;
using System.Collections.Generic;
using System.Text;

namespace OrderFunction
{
    public class OrderDetails
    {
        public Cargo Cargo { get; set; }
        public DateTime OrderDate { get; set; }
        public int SalesVolume { get; set; }
        public double TotalOrderDetailsAmount { get; set; }


        public OrderDetails(Cargo cargo, int salesVolume)
        {
            Cargo = cargo;
            this.OrderDate = DateTime.Now;
            SalesVolume = salesVolume;
            this.TotalOrderDetailsAmount = SalesVolume * Cargo.UnitPrice;
        }
        public override string ToString()
        {
            return $"订单日期：\t{OrderDate.Year}. {OrderDate.Month}. {OrderDate.Day}\n" +
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
            int hashCode = -11101986;
            hashCode = hashCode * -1521134295 + EqualityComparer<Cargo>.Default.GetHashCode(Cargo);
            hashCode = hashCode * -1521134295 + OrderDate.GetHashCode();
            hashCode = hashCode * -1521134295 + SalesVolume.GetHashCode();
            hashCode = hashCode * -1521134295 + TotalOrderDetailsAmount.GetHashCode();
            return hashCode;
        }
    }
}
