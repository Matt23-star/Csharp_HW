using System;
using System.Collections.Generic;
using System.Text;

namespace OrderFunction
{
    public class Client
    {
        public String Name { get; set; }
        public String PhoneNumber { get; set; }
        public String Address { get; set; }
        public Client(string name, string phoneNumber, string address)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public Client()
        {
        }

        public override string ToString()
        {
            return $"客户姓名：\t{Name}\n" +
                $"客户电话：\t{PhoneNumber}\n" +
                $"客户地址：\t{Address}\n";
        }

        public override bool Equals(object obj)
        {
            Client client = obj as Client;
            if (client != null)
            {
                return client.Name == this.Name
                    && client.PhoneNumber == this.PhoneNumber
                    && client.Address == this.Address;
            }
            return false;
        }

        public override int GetHashCode()
        {
            int hashCode = -909024265;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(PhoneNumber);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Address);
            return hashCode;
        }
    }
}
