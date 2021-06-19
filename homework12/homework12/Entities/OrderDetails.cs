using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Homework12.Entities
{
    [Serializable]
    public class OrderDetails
    {
        [Key]
        public Cargo Cargo { get; set; }
        public String CargoName
        {
            get
            {
                if (Cargo != null) return Cargo.CargoName;
                return "";
            }
        }
        public double CargoUnitPrice
        {
            get
            {
                if (Cargo != null) return Cargo.UnitPrice;
                return 0;
            }
        }
        public int SalesVolume { get; set; }
        public double TotalOrderDetailsAmount { get; }
        [ForeignKey("Order_DetailId")]
        public int Index { get; set; } //序号

        public OrderDetails()
        {

        }

        public OrderDetails(Cargo cargo, int salesVolume)
        {
            Cargo = cargo;
            SalesVolume = salesVolume;
            this.TotalOrderDetailsAmount = SalesVolume * Cargo.UnitPrice;
        }


        public override string ToString()
        {
            return  $"商品名：\t{Cargo.CargoName}\n" +
                $"单价：\t{Cargo.UnitPrice}\n" +
                $"数量：\t{SalesVolume}\n" +
                $"订单明细金额：\t{TotalOrderDetailsAmount}\n";
        }

        public override bool Equals(Object obj)
        {
            OrderDetails orderDetails = obj as OrderDetails;
            if (orderDetails != null)
            {
                if (this.Cargo.Equals(orderDetails.Cargo))
                {
                    if (this.SalesVolume == orderDetails.SalesVolume)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public override int GetHashCode()
        {
            int hashCode = 772028094;
            hashCode = hashCode * -1521134295 + EqualityComparer<Cargo>.Default.GetHashCode(Cargo);
            hashCode = hashCode * -1521134295 + SalesVolume.GetHashCode();
            hashCode = hashCode * -1521134295 + TotalOrderDetailsAmount.GetHashCode();
            return hashCode;
        }
    }
}
