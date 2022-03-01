using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections;

namespace Lecture2
{
    internal class Homework1
    {
        internal static void Run()
        {
            Input();
        }

        public static void Input()
        {
            string input = "Please contact us by phone (+001 222 222 2222) or by email " +
                  "at example@gmail.com or at test.user@yahoo.co.uk.This is not email: " +
                  "test@test. This also: @gmail.com " +
                  "Neither this: a@a.b.";
            Logic(input);
        }

        public static void Logic(string input)
        {
            string pattern = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            MatchCollection collection = Regex.Matches(input, pattern);
            Console.WriteLine("Matches found {0}", collection.Count);

            Output(collection);
        }

        public static void Output(MatchCollection output)
        {
            if (output.Count > 0)
            {
                foreach (Match m in output)
                {
                    Console.WriteLine(m.Groups[2]);
                }
            }
        }
    }
}
