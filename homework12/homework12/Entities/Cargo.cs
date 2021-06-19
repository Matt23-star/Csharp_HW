using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Homework12.Entities
{
    [Serializable]
    public class Cargo
    {
        [Key]
        public int CargoId { set; get; }

        [Required]
        public String CargoName { get; set; }
        public String CargoNumber { get; set; }
        [Required]
        public double UnitPrice { get; set; }

        public Cargo(String cargoName,String cargoNumber,double unitPrice)
        {
            this.CargoName = cargoName;
            this.CargoNumber = cargoNumber;
            this.UnitPrice = unitPrice;
        }

        public Cargo()
        {
        }

        public override string ToString()
        {
            return $"货物名：\t{CargoName}\n" +
                $"货物号：\t{CargoNumber}\n" +
                $"单价：\t{UnitPrice}\n";
        }

        public override bool Equals(object obj)
        {
            Cargo cargo = obj as Cargo;
            if (cargo != null)
            {
                return cargo.CargoName == this.CargoName && cargo.CargoNumber == this.CargoNumber && this.UnitPrice == cargo.UnitPrice;
            }
            return false;
        }

        public override int GetHashCode()
        {
            int hashCode = 287349786;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CargoName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CargoNumber);
            hashCode = hashCode * -1521134295 + UnitPrice.GetHashCode();
            return hashCode;
        }
    }
}
