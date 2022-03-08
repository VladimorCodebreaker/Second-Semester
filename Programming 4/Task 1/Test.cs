using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_4.Task_1
{
    internal class Test
    {
        public static void Run()
        {
            GenericList<string> name = new GenericList<string>(45);

            name.Add("Vladimir");
            name.Add("Vivaldi");
            name.Add("Wolfgang");
            name.Add("Lena");

            name.ToString();

            name.SearchForItemByValue("Lena");

            name.RemoveByIndex(0);

            name.ToString();

            name.AccessItemByIndex(0);

            name.InsertAtGivenPosition("laura", 0);

            name.ToString();

            name.Clear();

            name.ToString();
        }
    }
}
