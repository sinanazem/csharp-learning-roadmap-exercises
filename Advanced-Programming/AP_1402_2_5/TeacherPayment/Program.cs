using System;

namespace Test
{
    class Program
    {
        static void Main()
        {
            Teacher sina = new Teacher("snun2432","Sina", "Nazem", 50, 100);
            double sinaSalary = sina.GetSalary();
            Console.WriteLine(sina.Name + " " + sina.Lastname + " Salary is : " + sinaSalary);
        }
    }
    class Teacher
    {
        private string _id;
        private string _name;
        private string _lastname;
        private double _hours;
        private double _paymentsPerHours;


        public String Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        public double Hours
        {
            get { return _hours; }
            set { _hours = value; }

        }

        public double PaymentsPerHours
        {
            get { return _paymentsPerHours; }
            set { _paymentsPerHours = value; }
        }

        public Teacher(){}
        public Teacher(string id, string name, string lastname, double hours, double paymentsPerHours)
        {
            _id = id;
            _name = name;
            _lastname = lastname;
            _hours = hours;
            _paymentsPerHours = paymentsPerHours;
        }


        public double GetSalary()
        {
            return Hours * PaymentsPerHours;
        }
    }
}
