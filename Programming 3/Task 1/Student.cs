using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_4.Task_1
{
    internal class Student
    {
        public static int Count;

        private string fullName; 
        private string course;
        private string subject;
        private string university; 
        private string email;
        private int phoneNumber;

        public string FullName
        {
            get { return this.fullName; }  
       
            set { this.fullName = value; } 
        }

        public string Course
        {
            get { return this.course; }
            set { this.course = value; }
        }
        
        public string Subject
        {
            get { return this.subject; }
            set { this.subject = value; }
        }

        public string University
        {
            get { return this.university; } 
            set { this.university = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public int PhoneNumber
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }

        public Student() : this("Paul Becker")
        {

        }

        public Student(string FullName)
        {
            this.fullName = FullName; 
            this.course = Course; 
            this.subject = Subject;
            this.university = University;
            this.email = Email;
            this.phoneNumber = PhoneNumber;

            Count++;
        }

        public Student(string FullName, string Course, string Subject, string University,
            string Email, int PhoneNumber)
        {
            this.fullName = FullName; 
            this.course = Course;
            this.subject = Subject;
            this.university = University;
            this.email = Email;
            this.phoneNumber = PhoneNumber;

            Count++;
        }

        public void Print()
        {
            Console.WriteLine("Student: {0}\n" +
                "Course: {1}\n" +
                "Subject: {2}\n" +
                "University: {3}\n" +
                "Email: {4}\n" +
                "Phone number: {5}\n", 
                FullName, Course, Subject, University, Email, PhoneNumber);
        }

    }
}
