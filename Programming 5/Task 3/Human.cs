using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_5.Task_3
{
    internal class Human
    {
        public Human(string _name)
        {
            this.name = _name;
        }

        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public override string ToString()
        {
            return name + " ";
        }
    }
}
