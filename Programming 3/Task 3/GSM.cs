using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_4.Task_3
{
    internal class GSM : Call
    {
        int num = 0; double cumulativeSum = 0; int max = 0; List<int> longestConversation = new List<int>();

        Call call = new Call();
        public void Add(DateTime Date, DateTime Start, int Duration)
        {
            Console.WriteLine("---------Call Price---------");

            num++; // Keep track of the number of calls
            longestConversation.Add(Duration); // Check for longest conversation

            double sum = Duration * 0.37d;
            List<double> sumlist = new List<double>();
            sumlist.Add(sum);

            CalculatePrice(sumlist);

            call._Call = ("Date: " + Date + " Start: " + Start + " Duration: " + Duration).ToString();
            call.CallHistory.Add(call._Call);
        }

        public void Delete(string callRecord)
        {
            call.CallHistory.Remove(callRecord);
        }

        public void Clear()
        {
            call.CallHistory.Clear();
        }

        public void Count(double price)
        {
            Console.WriteLine(call.CallHistory.Count());
        }

        public void Print()
        {
            int num = 0;
            Console.WriteLine("\n---------Call History---------");
            foreach (string element in call.CallHistory)
            {
                Console.WriteLine(element + "   ||Num:" + num++);
            }
        }

        public void CalculatePrice(List<double> output)
        {
            foreach (var element in output)
            {
                Console.WriteLine("Number of call: " + (num - 1) + "   Price for call: " + element);
                cumulativeSum += element;
            }
        }

        public void CumulativePrice()
        {
            Console.WriteLine("\n\nCumulative Price: " + cumulativeSum);
        }
        public void LongestConversation()
        {
            Console.WriteLine("\nLongest conversation: " + longestConversation.Max());
        }

    }
}
