using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_and_Algo_2.Task_Answers
{
    internal class DoubleLinkedList<T> : IEnumerable<T>
    {
        /// <summary>
        /// Initialize a new instance of DoubleLinkedList class that is empty.
        /// </summary>
        public DoubleLinkedList()
        {

        }

        /// <summary>
        /// Initialized a new instance of the DoubleLinkedList class that
        /// contains elements copied from the specified collection.
        /// </summary>
        /// <typeparam name="collection">The collection contaisn elements to seed</typeparam>

        public DoubleLinkedList(IEnumerable<T> collection)
        {
            if (collection == null)
            {
                throw new NullReferenceException("Seed collection cannot be null.");
            }

            foreach (var item in collection)
            {
                this.AddLast(item);
            }
        }

        /// <summary>
        /// Gets the first node of the collection.
        /// </summary>
        public ListNode<T> First { get; private set; }

        /// <summary>
        /// Gets the last node of the collection.
        /// </summary>
        public ListNode<T> Last { get; private set; }

        /// <summary>
        /// Gets the number of nodex actually contained in the collection
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Adds a new node containing the specified value at the start 
        /// of the collection .
        /// </summary>
        /// <typeparam name="value">The value to add at the start of the collection.</typeparam>
        public void AddFirst(T value)
        {
            var linkedListNode = new ListNode<T>(value);

            if (this.First == null)
            {
                this.First = this.Last = linkedListNode;
            }
            else
            {
                linkedListNode.Next = this.First;
                this.First.Previous = linkedListNode;
                this.First = linkedListNode;
            }

            this.Count++;
        }

        /// <summary>
        /// Adds a new node containing the specified value at the end of the collection.
        /// </summary>
        /// <typeparam name="value">The value to add at the end of the collection</typeparam>
        public void AddLast(T value)
        {
            var linkedListNode = new ListNode<T>(value);

            if (this.Last == null)
            {
                this.First = this.Last = linkedListNode;
            }
            else
            {
                linkedListNode.Previous = this.Last;
                this.Last.Next = linkedListNode;
                this.Last = linkedListNode;
            }

            this.Count++;
        }

        /// <summary>
        /// Adds a new node containing the specified value before the specified existing node in the collection.
        /// </summary>
        /// <typeparam name="node">The ListNode before which to insert a new ListNode containing value.</typeparam>
        /// <typeparam name="value">The value to add to the collection.</typeparam>
        public void AddBefore(ListNode<T> node, T value)
        {
            if (node == null)
            {
                return;
            }

            var newNode = new ListNode<T>(value);

            if (node.Previous == null)
            {
                node.Previous.Next = newNode;
                node.Previous = newNode;
            }
            else
            {
                newNode.Next = node;
                newNode.Previous = node.Previous;

                node.Previous.Next = newNode;
                node.Previous = newNode;
            }

            if (node == this.First)
            {
                this.First = newNode;
            }

            this.Count++;
        }

        /// <summary>
        /// Adds a new node containing the specified value after the 
        /// specified existing node in the collection.
        /// </summary>
        /// <typeparam name="node">The ListNode aafter which to inesrt a new ListNode containing value.</typeparam>
        /// <typeparam name="value">The value to add to the collection.</typeparam>
        public void AddAfter(ListNode<T> node, T value)
        {
            if (node == null)
            {
                return;
            }

            var newNode = new ListNode<T>(value);

            if (node.Next == null)
            {
                node.Next = newNode;
                newNode.Previous = node;
            }
            else
            {
                newNode.Next = node.Next;
                newNode.Previous = node;

                node.Next.Previous = newNode;
                node.Next = newNode;
            }

            if (node == this.Last)
            {
                this.Last = newNode;
            }

            this.Count++;
        }

        /// <summary>
        /// Removes the first occurrence of the specified value from the collection.
        /// </summary>
        /// <typeparam name="value">The value to remove from the collection.</typeparam>
        public void Remove(T value)
        {
            var node = this.Find(value);
            this.RemoveReference(ref node);
        }

        /// <summary>
        /// Removes the node at the start of the collection.
        /// </summary>
        public void RemoveFirst()
        {
            var node = this.First;
            this.RemoveReference(ref node);
        }

        /// <summary>
        /// Removes the node at the end of the collection.
        /// </summary>
        public void RemoveLast()
        {
            var node = this.Last;
            this.RemoveReference(ref node);
        }

        /// <summary>
        /// Finds the first node that contains the specified value;
        /// </summary>
        /// <param name="value">The value to locate in the collection</param>
        public ListNode<T> Find(T value)
        {
            var currentNode = this.First;

            while (currentNode != null)
            {
                if (currentNode.Value.Equals(value))
                {
                    return currentNode;
                }

                currentNode = currentNode.Next;
            }

            return null;
        }

        /// <summary>
        /// Finds the last node that contains the specified value.
        /// </summary>
        /// <typeparam name="value">The value to locate in the collection.</typeparam>
        public ListNode<T> FindLast(T value)
        {
            var currentNode = this.Last;

            while (currentNode != null)
            {
                if (currentNode.Value.Equals(value))
                {
                    return currentNode;
                }

                currentNode = currentNode.Previous;
            }

            return null;
        }

        /// <summary>
        /// Removes all the nodes from the collection
        /// </summary>
        public void Clear()
        {
            this.First = this.Last = null;
            this.Count = 0;
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        public IEnumerator<T> GetEnumerator()
        {
            var currentNode = this.First;

            while (currentNode != null)
            {
                yield return currentNode.Value;

                currentNode = currentNode.Next;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private void RemoveReference(ref ListNode<T> node)
        {
            if (node != null)
            {
                if (node.Previous != null)
                {
                    node.Previous.Next = node.Next;
                }

                if (node.Next != null)
                {
                    node.Next.Previous = node.Previous;
                }

                if (node == this.First)
                {
                    this.First = node.Next;
                }

                if (node == this.Last)
                {
                    this.Last = node.Previous;
                }

                node = null;

                this.Count--;
            }
        }
    }
}
