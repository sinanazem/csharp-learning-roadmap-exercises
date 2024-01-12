using System;

namespace CircleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(3);
            Console.WriteLine("Masahat is: " + circle.Masahat());
            Console.WriteLine("Mohit is: " + circle.Mohit());
        }

    }

    public class Circle
    {
        public double pi = 3.14;
        private double _r;

        public double R
        {
            get { return _r; }
            set { _r = value; }
        }

        public Circle() { }
        public Circle(double r)
        {
            _r = r;
        }

        public double Mohit()
        {
            return 2 * _r * pi;
        }

        public double Masahat()
        {
            return _r * _r * pi;
        }
    }
}