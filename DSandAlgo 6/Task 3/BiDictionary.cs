using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.InteropServices;

namespace DSandAlgo_6.Task_3
{
    internal class BiDictionary<T>
    {
        private T key1;
        private T key2;

        private HashSet<T> values = new HashSet<T>();

        public bool AddKey(T Key1, [Optional] T Key2)
        {
            if (key1 != null && key2 != null)
            {
                return false;
            }

            if (Key1 == null)
            {
                throw new Exception("Can't be null!");
            }
            key1 = Key1;

            if (Key2 == null)
            {
                throw new Exception("Can't be null!");
            }
            key2 = Key2;

            return true;
        }

        public void AddValue(T value)
        {
            if (value != null)
            {
                values.Add(value);
            }
        }

        public void FastSearch(T Key1, [Optional] T Key2)
        {
            if (Key1.Equals(key1) || Key2.Equals(key2))
            {
                Console.Write("Key1: " + key1 + " Key2: " + key2 + " Value: ");
                foreach (var value in values)
                {
                    Console.Write(value + " | ");
                }
                Console.WriteLine("\n");
            }
            else
            {
                throw new KeyNotFoundException("Didn't find the key. Key needed to search!");
            }
        }

        public void Print()
        {
            Console.WriteLine("--------BiDictionary--------\n");

            Console.WriteLine("Key1: \"{0}\" ", key1);

            Console.WriteLine("Key2: \"{0}\" ", key2);

            foreach (var value in values)
            {
                Console.WriteLine("Value: \"{0}\" ", value);
            }
        }
    }
}
