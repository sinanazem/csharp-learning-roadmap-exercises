using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Time(t) for Caculate Distance Gravity formula: ");
            double time = Convert.ToDouble(Console.ReadLine());

            GravityClass obj = new GravityClass(time);
            Console.WriteLine("Distance: " + obj.GetDistance());

        }
    }

    class GravityClass
    {
        private double _g = 9.8;
        private double _t;

        public double T
        {
            get { return _t; }
            set {
                if (_t > 0)
                {
                    _t = value;
                }
            }
        }
        public GravityClass() { }
        public GravityClass(double t)
        {
            _t = t;
        }

        public double GetDistance()
        {
            return 0.5 * _g * _t;
        }
    }

}
