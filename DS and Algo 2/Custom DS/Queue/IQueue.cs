using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_and_Algo_2.Queue
{
    public interface IQueue<T>
    {
        void Enqueue(T value);

        T Peek();

        T Dequeue();

        void Clear();
    }
}
