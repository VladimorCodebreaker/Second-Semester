using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace DSandAlgo_5.Lecture
{
    public class Store
    {
        OrderedBag<Product> products = new OrderedBag<Product>();

        public void AddProduct(Product product)
        {
            this.products.Add(product);
        }

        public ICollection<Product> SearchInPriceRange(decimal min, decimal max)
        {
            Product startProduct = new Product(string.Empty, min);
            Product endProduct = new Product(string.Empty, max);

            return this.products
                .Range(startProduct, true, endProduct, true)
                .Take(20)
                .ToList();
        }
    }
}
