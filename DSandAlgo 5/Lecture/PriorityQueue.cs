using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace DSandAlgo_5.Lecture
{
    public class PriorityQueue<T>
    {
        private OrderedBag<T> queue;
        
        public int Count
        {
            get { return this.queue.Count; }
        }

        public PriorityQueue()
        {
            this.queue = new OrderedBag<T>();
        }

        public void Enqueue(T element)
        {
            this.queue.Add(element);
        }

        public T Dequeue()
        {
            return this.queue.RemoveFirst();
        }
    }
}
