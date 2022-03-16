using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace DSandAlgo_6.Task_2
{
    internal class LargeTradeCompany
    {
        //private static List<int> price { get; set; }

        private static SortedSet<int> distinctPrices = new SortedSet<int>();

        public static void Logic()
        {
            var products = new OrderedMultiDictionary<int, Product>(true);

            for (int i = 0; i < 500; i++)
            {
                distinctPrices.Add(i);
                i++;
            }

            for (int i = 0; i < 500; i++)
            {
                Product productA = new Product(i, "Taichong", "Fork");
                Product productB = new Product(i, "alibaba", "washibi");
                Product productC = new Product(i, "Guancho food", "seafood");
                i++;

                foreach (int d in distinctPrices)
                {
                    products.Add(d, productA);
                    products.Add(d, productB);
                    products.Add(d, productC);
                }
            }
            var range = products.Range(0, true, 300, true);

            Console.WriteLine(range.Count());

            foreach (var pair in products.Range(200, true, 300, true))
            {
                Console.WriteLine(pair.Key + " " + pair.Value.ToString());
            }
        }

    }
}
