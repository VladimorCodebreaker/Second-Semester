using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Programming_4.Task_2
{
    internal class GSMTest
    {
        public static void Run()
        {
            MobilePhone phoneA = new MobilePhone("ZvkS334", "Samsung", 499, "Jonathan");
            Battery batteryA = new Battery(234, 33, 12);
            Display displayA = new Display(12, "blue");


            MobilePhone phoneB = new MobilePhone("KEGI", "Apple", 999, "Vladimir");
            Battery batteryB = new Battery(1223, 23, 329);
            Display displayB = new Display(69, "black");

            MobilePhone phoneC = new MobilePhone("fwfwgwq", "Xiaomi", 499, "Sarah");
            Battery batteryC = new Battery(234, 33, 12);
            Display displayC = new Display(12, "blue");

            MobilePhone phoneD = new MobilePhone("fwwgwgw95", "Nokia", 999, "Paul");
            Battery batteryD = new Battery(1223, 23, 329);
            Display displayD = new Display(69, "black");

            GSM gsm = new GSM();
            Console.WriteLine("----------Phone number A-------");

            gsm.Print(phoneA, batteryA, displayA);
            Console.WriteLine();
            Console.WriteLine("----------Phone number B-------");

            gsm.Print(phoneB, batteryB, displayB);
            Console.WriteLine();
            Console.WriteLine("----------Phone number C-------");

            gsm.Print(phoneC, batteryC, displayC);
            Console.WriteLine();
            Console.WriteLine("----------Phone number D-------");

            gsm.Print(phoneD, batteryD, displayD);

            Console.WriteLine();

            Console.WriteLine("Nokia Phone----------- ...\n");
            phoneA.NokiaN95(phoneD, batteryD, displayD);
        }
    }
}
