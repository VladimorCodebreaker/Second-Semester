using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandAlgo_6.Task_2
{
    internal class Product : IComparable<Product>
    {
        private int barcode { get; set; }
        private string vendor { get; set; }
        private string title { get; set; }

        public Product(int Barcode, string Vendor, string Title)
        {
            this.barcode = Barcode;
            this.vendor = Vendor;
            this.title = Title;
        }

        public override string ToString()
        {
            Console.WriteLine("Title: " + title + " Barcode: " + barcode + " Vendor: " + vendor);
            return null;
        }

        public int CompareTo(Product other)
        {
            return other.title.CompareTo(this.title);
        }
    }
}
