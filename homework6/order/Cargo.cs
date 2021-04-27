using System;
using System.Collections.Generic;
using System.Text;

namespace order
{
    public class Cargo
    {
        public String CargoName { get; set; }
        public String CargoNumber { get; set; }
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
            return cargo.CargoName == this.CargoName && cargo.CargoNumber == this.CargoNumber && this.UnitPrice == cargo.UnitPrice;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(CargoName, CargoNumber, UnitPrice);
        }
    }
}
