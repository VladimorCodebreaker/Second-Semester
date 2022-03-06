using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandAlgo_5.Lecture
{
    public class Product : IComparable<Product>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public int CompareTo(Product other)
        {
            return (int)(this.Price - other.Price);
        }

        public override string ToString()
        {
            return String.Format("{0}: {1} -> {2:C}", this.GetType().Name, this.Name, this.Price);
        }
    }
}
