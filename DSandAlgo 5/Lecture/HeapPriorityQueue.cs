using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandAlgo_5.Lecture
{
    internal class HeapPriorityQueue<T> where T : IComparable
    {
        private const int InitialCapacity = 16;

        private T[] heap;
        private int index;

        /// <summary>
        /// Creates a new priority queue. Implementation is based on the binary heap data structure.
        /// </summary>
        public HeapPriorityQueue()
        {
            this.heap = new T[InitialCapacity];
            this.index = 1;
        }

        public void Enqueue(T element)
        {
            this.IncreaseArrayIfNecessary();

            this.heap[this.index] = element;

            int childIndex = this.index;
            int parentindex = childIndex / 2;
            this.index++;

            while (parentindex >= 1 && this.heap[childIndex].CompareTo(this.heap[parentindex]) < 0)
            {
                T swapValue = this.heap[parentindex];
                this.heap[parentindex] = this.heap[childIndex];
                this.heap[childIndex] = swapValue;

                childIndex = parentindex;
                parentindex = childIndex / 2;
            }
        }

        public T Dequeue()
        {
            T result = this.heap[1];

            this.heap[1] = this.heap[this.Count];
            this.index--;

            int rootIndex = 1;
            int minChild;

            while (true)
            {
                int leftChildIndex = rootIndex * 2;
                int rightChildIndex = rootIndex * 2 + 1;

                if (leftChildIndex > this.index)
                {
                    break;
                }

                if (rightChildIndex > this.index)
                {
                    minChild = leftChildIndex;
                }
                else if (this.heap[leftChildIndex].CompareTo(this.heap[rightChildIndex]) < 0)
                {
                    minChild = leftChildIndex;
                }
                else
                {
                    minChild = rightChildIndex;
                }

                if (this.heap[minChild].CompareTo(this.heap[rootIndex]) < 0)
                {
                    T swapValue = this.heap[rootIndex];
                    this.heap[rootIndex] = this.heap[minChild];
                    this.heap[minChild] = swapValue;

                    rootIndex = minChild;
                }
                else
                {
                    break;
                }
            }

            return result;
        }

        public int Count
        {
            get
            {
                return this.index - 1;
            }
        }

        public T Peek()
        {
            return this.heap[1];
        }

        private void IncreaseArrayIfNecessary()
        {
            if (this.index >= this.heap.Length - 1)
            {
                T[] copiedHeap = new T[this.heap.Length * 2];

                Array.Copy(this.heap, 0, copiedHeap, 0, this.heap.Length);

                this.heap = copiedHeap;
            }
        }
    }
}
