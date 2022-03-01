using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Hashtable
{
    internal class KeyValuePair<TKey, TValue>
    {
        public TKey Key { get; private set; }
        public TValue Value { get; set; }

        public KeyValuePair(TKey key, TValue value)
        {
            this.Key = key;
            this.Value = value;
        }

        public override string ToString()
        {
            return String.Format("[{0}, {1}", this.Key, this.Value);
        }
    }
}
