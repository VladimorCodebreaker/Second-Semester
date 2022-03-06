using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Programming_4.Task_3
{
    internal class Call
    {
        private DateTime date;
        private DateTime start;
        private int duration;

        public List<string> CallHistory { get; set; } = new List<string>();

        private string call;

        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }
        public DateTime Start
        {
            get { return this.start; }
            set { this.start = value; }
        }
        public int Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }
        public string _Call
        {
            get { return this.call; }
            set { this.call = value; }
        }
    }
}
