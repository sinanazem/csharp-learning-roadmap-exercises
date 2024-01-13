using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter 'net salary' : ");
            double netSalary = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Please Enter 'insurance' : ");
            double insurance = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Please Enter Tax : ");
            double tax = Convert.ToDouble(Console.ReadLine());
            
            EmployeePay employee = new EmployeePay(netSalary, insurance, tax);
            Console.WriteLine("Daryafti: " + employee.CalculatePay());
        }
    }

    class EmployeePay
    {
        private double _netSalary;
        private double _insurance;
        private double _tax;

        public double NetSalary
        {
            get {return _netSalary; }
            set
            {
                if (value > 0)
                {
                    _netSalary = value;
                }
            }
        }
        public double Insurance
        {
            get { return _insurance; }
            set
            {
                if (value > 0)
                {
                    _insurance = value;
                }
            }
        }
        public double Tax
        {
            get { return _tax; }
            set
            {
                if (value > 0)
                {
                    _tax = value;
                }
            }
        }
        public EmployeePay() { }
        public EmployeePay(double netSalary, double insurance, double tax)
        {
            _netSalary = netSalary;
            _insurance = insurance;
            _tax = tax;

        }

        public double CalculatePay()
        {
            return (_netSalary - _insurance) / _tax;
        }
    }
}