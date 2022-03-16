using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandAlgo_6.Task_3
{
    internal class Test
    {
        public static void Run()
        {
            BiDictionary<string> dictionaryA = new BiDictionary<string>();

            dictionaryA.AddKey("firstName", "lastName");

            dictionaryA.AddValue("Vladimir Schmadlak");
            dictionaryA.AddValue("Maria Schgenova");
            dictionaryA.AddValue("Thomas Czarski");

            dictionaryA.AddKey("Key1", "Key2");

            dictionaryA.AddValue("Paul Meier");

            dictionaryA.Print();

            Console.WriteLine("\n");

            dictionaryA.FastSearch("firstName", "lastName");

            BiDictionary<string> dictionary = new BiDictionary<string>();

            dictionary.AddKey("firstName", "lastName");

            dictionary.AddValue("Vladimir Schmadlak");
            dictionary.AddValue("Maria Schgenova");
            dictionary.AddValue("Thomas Czarski");

            dictionary.AddKey("Key1", "Key2");

            dictionary.AddValue("Paul Meier");

            dictionary.Print();

            Console.WriteLine("\n");

            dictionary.FastSearch("aldkaw", "aslkad");
        }
    }
}
