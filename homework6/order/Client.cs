using System;
using System.Collections.Generic;
using System.Text;

namespace order
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
            return client.Name == this.Name
                && client.PhoneNumber == this.PhoneNumber
                && client.Address == this.Address;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, PhoneNumber, Address);
        }
    }
}
