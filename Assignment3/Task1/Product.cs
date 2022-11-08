using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }

        public Product()
        {

        }
        internal Product(string productName, double productPrice) : this()
        {
            Name = productName;
            Price = productPrice;
        }
        public Product(string name, double price, string description, string color) : this(name, price)
        {
            Description = description;
            Color = color;
        }
    }
}
