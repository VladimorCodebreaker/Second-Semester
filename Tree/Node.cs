using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_and_Algo_3.Tree
{
    internal class Node<T>
    {
        private ISet<Node<T>> children;
        public T Value { get; set; }
        public Node<T> Parent { get; set; }

        public Node(T value)
        {
            this.Value = value;
            this.children = new HashSet<Node<T>>();
        }

        public ISet<Node<T>> Children
        {
            get
            {
                return this.children;
            }
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("Children collection instance cannot be null");
                }
                this.children = value;
            }
        }

        public override string ToString()
        {
            var output = new StringBuilder();
            output.AppendFormat("Node -> Value: {0}", this.Value);

            if (this.Children.Count > 0)
            {
                var childrenValues = this.Children.Select(c => c.Value);
                var valuesToString = string.Join(", ", childrenValues);
                output.AppendFormat(" | Direct children: {{ {0} }}", valuesToString);
            }

            return output.ToString();
        }
    }
}
