using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_and_Algo_2.Task_Answers
{
    internal class ListNode<T>
    {
        public T Value { get; set; }
        public ListNode<T> Previous { get; set; }
        public ListNode<T> Next { get; set; }

        public ListNode(T value)
        {
            this.Value = value;
        }

       public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}
