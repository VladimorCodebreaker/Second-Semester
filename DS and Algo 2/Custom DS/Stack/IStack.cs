using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_and_Algo_2.Stack
{
    internal interface IStack<T>
    {
        void Push(T value);

        T Peek();

        T Pop();

        void Clear();
    }
}
