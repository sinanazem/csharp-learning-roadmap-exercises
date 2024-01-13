using System;
using System.ComponentModel;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Id:");
            string id = Console.ReadLine();
            Console.Write("Name:");
            string name = Console.ReadLine();
            Console.Write("Last Name:");
            string lastname = Console.ReadLine();
            Console.Write("GPA:");
            double gpa= Convert.ToDouble(Console.ReadLine());
            if (gpa < 0)
            {
                Console.WriteLine("Error: GPA must be bigger than 0!");
            }

            Student student_1 = new Student(id, name, lastname, gpa);
            Console.WriteLine("Student Status: " + student_1.Status());

        }
    }

    public class Student
    {
        private string _id;
        private string _name;
        private string _lastname;
        private double _gpa;
        
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }
        public double Gpa
        {
            get { return _gpa; }
            set
            {
                if(value > 0)
                {
                    _gpa = value;
                }
                else
                {
                    _gpa = 0;
                }
            }
        }
        public Student() { }
        public Student(string id, string name, string lastname, double gpa)
        {
            _id = id;
            _name = name;
            _lastname = lastname;
            _gpa = gpa;
        }

        public string Status()
        {
            if (_gpa >= 12)
            {
                return "Student Pass! (Normal)";
            }
            else
            {
                return "Student Not Pass! (Not Normal)";
            }
        }
    } 
}