using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Programming_4.Task_1
{
    internal class GenericList<T> where T : IComparable<T>
    {
        public T[] array { get; set; }
        private int index;

        public GenericList(int capacity)
        {
            array = new T[capacity];
            index = 0;
        }

        public void Add(T item)
        {
            DoubleCapacity();

            if (array[index] == null)
            {
                array[index] = item;
                index++;
            }
            else
            {
                Add(item);
            }
        }

        public void AccessItemByIndex(int index)
        {
            Console.WriteLine("Item: " + array[index]);
        }

        public void RemoveByIndex(int index)
        {
            for (int i = index; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = default(T);
        }

        public void InsertAtGivenPosition(T item, int position)
        {
            DoubleCapacity();

            for (int i = index; i > position - 1; i--)
            {
                array[i + 1] = array[i];
            }
            array[position] = item;
        }

        public void SearchForItemByValue(T value)
        {
            //foreach (T item in array)
            //{
            //    if (item.Equals(value))
            //    {
            //        Console.WriteLine("Item: " + item + " Index: " + Array.IndexOf(array, item));
            //    }
            //}

            int position = Array.IndexOf(array, value);

            if (position > -1)
            {
                Console.WriteLine("Value: " + value + " Index: " + position);
            }
        }

        public void Clear()
        {
            Array.Clear(array, 0, array.Length);
        }

        public override string ToString()
        {
            Console.WriteLine("\n");
            index = 0;
            foreach (T item in array)
            {
                if (item != null)
                {
                    Console.WriteLine($"Item: {item} || Index: {index}");
                    index++;
                }
            }
            Console.WriteLine("\n");
            return null;
        }

        public void DoubleCapacity()
        {
            if (index >= array.Length)
            {
                var tempArr = new T[array.Length * 2];

                Array.Copy(array, 0, tempArr, 0, array.Length);

                array = tempArr;
            }
        }
    }
}
