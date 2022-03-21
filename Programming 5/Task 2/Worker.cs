using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programming_5.Task_2
{
    internal class Worker : Human
    {
        public Worker(int Wage, int HoursWorked)
        {
            this.wage = Wage;
            this.hoursWorked = HoursWorked;
        }

        public int wage
        {
            get { return this.wage; }
            set
            {
                if (wage != 0)
                {
                    this.wage = value;
                }
            }
        }

        public int hoursWorked
        {
            get { return this.hoursWorked; }
            set
            {
                this.hoursWorked = value;
            }
        }

        public void CalculateHourlyWage()
        {
            throw new System.NotImplementedException();
        }
    }
}