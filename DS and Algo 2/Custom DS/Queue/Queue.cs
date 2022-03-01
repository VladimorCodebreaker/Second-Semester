using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using DS_and_Algo_2.Task_Answers;

namespace DS_and_Algo_2.Queue
{
    internal class Queue<T> : IQueue<T>, IEnumerable<T>
    {
        private readonly DoubleLinkedList<T> elements;

        /// <summary>
        /// Initialize a new instance of Queue class that is empty.
        /// Queue implementation uses DoubleLinkedList abstract data structure.
        /// </summary>
        public Queue()
        {
            this.elements = new DoubleLinkedList<T>();
        }

        /// <summary>
        /// Gets the number of elements contained in the collection.
        /// </summary>
        public int Count
        {
            get
            {
                return this.elements.Count;
            }
        }

        /// <summary>
        /// Adds an object to the end of the collection.
        /// </summary>
        public void Enqueue(T value)
        {
            this.elements.AddLast(value);
        }

        /// <summary>
        /// Returns the object at the beginning of the collection without removing it.
        /// </summary>
        public T Peek()
        {
            if (this.Count == 0)
            {
                throw new ArgumentException("There is no element in the queue.");
            }
            return this.elements.First.Value;
        }


        /// <summary>
        /// Removes and returns the object at the beginning of the collection.
        /// </summary>
        public T Dequeue()
        {
            if (this.Count == 0)
            {
                throw new ArgumentException("There is no element in the queue.");
            }

            T value = this.elements.First.Value;
            this.elements.RemoveFirst();

            return value;
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var element in this.elements)
            {
                yield return element;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
