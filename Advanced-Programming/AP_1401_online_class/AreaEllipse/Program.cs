using System;
using App;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Ellipse ellipse = new Ellipse(10,20);
            Console.WriteLine("Area is: " + ellipse.Caculate());
        }
    }

    class Ellipse
    {
        private double _r_max;
        private double _r_min;
        double Pi = 3.14;

        public double RMax
        {
            get { return _r_max; }
            set
            {
                if (_r_max > 0)
                {
                    _r_max = value;
                }
            }

        }
        public double RMin
        {
            get { return _r_min; }
            set
            {
                if (_r_min > 0)
                {
                    _r_min = value;
                }
            }

        }

        public Ellipse() { }
        public Ellipse(double r_max, double r_min)
        {
            _r_max = r_max;
            _r_min = r_min;
 
        }

        public double Caculate()
        {
            return Pi * _r_max * _r_min;
        }
    }
}