using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Homework.List
{
    internal class Node
    {
        public int data;
        public Node next;

        public Node(int value)
        {
            data = value;
            next = null;
        }

        public void Print()
        {
            Console.Write("|" + data + "|-->");
            if (next != null)
            {
                next.Print();
            }
            Console.WriteLine();
        }

        public void AddSorted(int data)
        {
            if (next == null)
            {
                next = new Node(data);
            }
            else if (data < next.data)
            {
                Node temp = new Node(data);
                temp.next = this.next;
                this.next = temp;
            }
            else
            {
                next.AddSorted(data);
            }
        }

        public void AddToEnd(int value)
        {
            if (next == null)
            {
                next = new Node(value);
            }
            else
            {
                next.AddToEnd(value);
            }
        }
    }

    internal class List
    {
        public Node head;
        public List()
        {
            head = null;
        }

        public void AddToEnd(int data)
        {
            if (head == null)
            {
                head = new Node(data);
            }
            else
            {
                head.AddToEnd(data);
            }
        }

        public void AddSorted(int data)
        {
            if (head == null)
            {
                head = new Node(data);
            }
            else if (data < head.data)
            {
                AddToStart(data);
            }
            else
            {
                head.AddSorted(data);
            }
        }

        public void AddToStart(int data)
        {
            if (head == null)
            {
                head = new Node(data);
            }
            else
            {
                Node temp = new Node(data);
                temp.next = head;
                head = temp;
            }
        }

        public void Print()
        {
            if (head != null)
            {
                head.Print();
            }
        }

        public static void Run()
        {
            //    Node node = new Node(0);
            //    node.AddToEnd(5);
            //    node.AddToEnd(6);
            //    node.AddToEnd(7);
            //    node.Print();

            //    List list = new List();
            //    list.AddToStart(0);
            //    list.AddToStart(5);
            //    list.AddToStart(6);
            //    list.AddToStart(7);
            //    list.Print();

            List list = new List();
            list.AddSorted(7);
            list.AddSorted(5);
            list.AddSorted(6);
            list.AddSorted(8);
            list.Print();
        }
    }

   
}
