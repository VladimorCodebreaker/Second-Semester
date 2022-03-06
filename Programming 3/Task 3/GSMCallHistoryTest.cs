using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_4.Task_3
{
    internal class GSMCallHistoryTest
    {
        public static void Run()
        {
            GSM call = new GSM();

            DateTime date1 = new DateTime(2015, 12, 20);
            DateTime start1 = new DateTime(2015, 12, 20, 10, 30, 0);
            int duration1 = 30;

            DateTime date2 = new DateTime(2022, 03, 02);
            DateTime start2 = new DateTime(2022, 03, 02, 12, 15, 0);
            int duration2 = 15;

            DateTime date3 = new DateTime(2022, 06, 04);
            DateTime start3 = new DateTime(2022, 06, 04, 18, 56, 0);
            int duration3 = 44;

            DateTime date4 = new DateTime(2018, 07, 18);
            DateTime start4 = new DateTime(2018, 07, 18, 10, 0, 0);
            int duration4 = 25;

            call.Add(date1, start1, duration1);
            call.Add(date2, start2, duration2);
            call.Add(date3, start3, duration3);
            call.Add(date4, start4, duration4);

            call.Print();

            call.CumulativePrice();
            call.LongestConversation();

            var deleteLongestCall = ("Date: " + date3 + " Start: " + start3 + " Duration: " + duration3).ToString();

            call.Delete(deleteLongestCall); // I know it's stupid but I'm too tired to implement something more sophisticated

            call.Print();

            call.Clear();

            call.Print();
        }
    }
}
