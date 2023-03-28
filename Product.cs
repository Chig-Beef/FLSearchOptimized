using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_Algorithm
{
    internal class Product
    {
        // These properties should not be externally modified
        public string Name { get; }
        public double Price { get; }
        public int Code { get; }

        public Product(string name, double price, int code)
        {
            Name = name;
            Price = price;
            Code = code;
        }

        public string[] getData()
        {
            return new string[3] { Name, Price.ToString("C2"), Code.ToString() };
        }
    }
}
