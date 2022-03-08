using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Programming_4.Task_3_School
{
    internal class Teacher
    {
        public List<Discipline> listOfDisciplines;

        public Teacher()
        {
            listOfDisciplines = new List<Discipline>();
        }

        public void Add(Discipline discipline)
        {
            listOfDisciplines.Add(discipline);
        }
    }
}
