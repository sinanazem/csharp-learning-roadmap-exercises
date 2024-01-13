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

            Console.WriteLine("Please Enter Angle Between B and C: ");
            double angle = Convert.ToDouble(Console.ReadLine());

            FindTriangleSide triangle = new FindTriangleSide(b, c, angle);
            double a = triangle.Caculate();
            Console.WriteLine("Side A is: " + a);


        }
    }
    public class FindTriangleSide
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
                if (value > 0)
                {
                    _angle = value;
                }
            }
        }

        public FindTriangleSide() { }
        public FindTriangleSide(double bSide, double cSide, double angle)
        {
            _bSide = bSide;
            _cSide = cSide;
            _angle = angle;
        }

        public double Caculate()
        {
            return Math.Sqrt(Math.Pow(_bSide, 2) + Math.Pow(_cSide, 2) - 2 * _bSide * _cSide * Math.Cos(_angle));
        }

    }
}
