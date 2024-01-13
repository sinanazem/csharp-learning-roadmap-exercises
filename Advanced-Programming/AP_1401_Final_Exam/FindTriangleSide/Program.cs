using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Side B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter Side C: ");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter Angle between B and C: ");
            double angle = Convert.ToDouble(Console.ReadLine());

            Triangle sampleTriangle = new Triangle(b, c, angle);
            Console.WriteLine("Side A: " + sampleTriangle.FindSide());
        }
    }

    public class Triangle
    {
        private double _bSide;
        private double _cSide;
        private double _angle;

        public double BSide
        {
            get { return _bSide; }
            set
            {
                if (value > 0)
                {
                    _bSide = value;
                }
            }
        }

        public double CSide
        {
            get { return _cSide; }
            set
            {
                if (value > 0)
                {
                    _cSide = value;
                }
            }
        }

        public double Angle
        {
            get { return _angle; }
            set
            {
                if (value > 0 && value < 180) // Validating the angle
                {
                    _angle = value;
                }
            }
        }

        public Triangle() { }

        public Triangle(double bSide, double cSide, double angle)
        {
            BSide = bSide;
            CSide = cSide;
            Angle = angle;
        }

        public double FindSide()
        {
            return Math.Sqrt(Math.Pow(_bSide, 2) + Math.Pow(_cSide, 2) - (2 * _bSide * _cSide * Math.Cos(_angle)));
        }
    }
}
