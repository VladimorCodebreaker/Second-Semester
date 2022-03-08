using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_4.Task_3_School
{
    internal class Discipline
    {
        private string name;
        private int numberOfLessons;
        private int numberOfExercises;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (this.name != null)
                {
                    this.name = value;
                }
            }
        }
        public int NumberOfLessons
        {
            get { return this.numberOfLessons; }
            set { this.numberOfLessons = value; }
        }
        public int NumberOfExercises
        {
            get { return this.numberOfExercises; }
            set { this.numberOfExercises = value; }
        }

        public Discipline(string Name)
        {
            this.name = Name;
            this.numberOfLessons = NumberOfLessons;
            this.numberOfExercises = NumberOfExercises;
        }
        public Discipline(string Name, int NumberOfLessons, int NumberOfExercises)
        {
            this.name = Name;
            this.numberOfLessons = NumberOfLessons;
            this.numberOfExercises = NumberOfExercises;
        }

        public override string ToString()
        {
            return name + " " + numberOfLessons + " " + numberOfExercises;
        }

    }
}
