using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2Lec1
{
    class Task6
    {
        public static void Run()
        {
            var input = Input();
            string keyword = "/";


            var logic = Logic(input, keyword);

            Output(logic);
        }

        public static string Input()
        {
            string url = @"http://www.cnn.com/video";
            return url;
        }

        public static string Logic(string input, string keyword)
        {
            int startPosition = 0;

            // Protocol
            int indexOne = input.IndexOf(keyword);
            int lengthOne = (indexOne + 2) - startPosition;

            string protocol = input.Substring(startPosition, lengthOne);

            // Server
            int indexTwo = input.IndexOf(keyword, indexOne + 2);
            var lengthTwo = indexTwo - indexOne;

            string server = input.Substring(indexOne, lengthTwo);

            // Resource
            string resource = input.Substring(indexTwo);

            string extract = "Protocol: " + protocol + " Server: " + server + " Resource: " + resource;
            return extract;

            #region Other Way of doing it
            //var _protocol = input.Substring(0, 4);
            // var _server = input.Substring(7, 11);
            // var _resource = input.Substring(18, 6);
            // var _concat = "Protocol: " + _protocol + " Server: " + _server + " Resource: " + _resource;
            // return _concat;
            #endregion
        }

        public static void Output(string output)
        {
            Console.WriteLine($"Extracted sentence: ");
            Console.Write(output + "\n");
        }
    }
}
