using System;
using System.Buffers.Text;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Triangle Base: ");
            double triangleBase = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter Triangle Side1: ");
            double triangleSide1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter Triangle Side2: ");
            double triangleSide2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter Triangle Height: ");
            double triangleHeight = Convert.ToDouble(Console.ReadLine());

            Triangle sampleTriangle = new Triangle(triangleBase, triangleSide1, triangleSide2, triangleHeight);
            Console.WriteLine("Triangle Perimeter: " + sampleTriangle.CalculatePerimeter());
            Console.WriteLine("Triangle Area: " + sampleTriangle.CalculateArea());


            Console.WriteLine("Please Enter Trapezoid Base1: ");
            double trapezoidBase1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter Trapezoid Base2: ");
            double trapezoidBase2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter Trapezoid Side1: ");
            double trapezoidSide1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter Trapezoid Side2: ");
            double trapezoidSide2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter Trapezoid Height: ");
            double trapezoidHeight = Convert.ToDouble(Console.ReadLine());

            Trapezoid sampleTrapezoid = new Trapezoid(trapezoidBase1, trapezoidBase2, trapezoidSide1, trapezoidSide2, trapezoidHeight);
            Console.WriteLine("Trapezoid Perimeter: " + sampleTrapezoid.CalculatePerimeter());
            Console.WriteLine("Trapezoid Area: " + sampleTrapezoid.CalculateArea());
        }
    }
    class Triangle
    {
        private double _base;
        private double _side1;
        private double _side2;
        private double _height;

        public double Base
        {
            get { return _base; }
            set
            {
                if (value > 0)
                {
                    _base = value;
                }
            }
        }
        public double Side1
        {
            get { return _side1; }
            set
            {
                if (value > 0)
                {
                    _side1 = value;
                }
            }
        }
        public double Side2
        {
            get { return _side2; }
            set
            {
                if (value > 0)
                {
                    _side2 = value;
                }
            }
        }
        public double Height
        {
            get { return _height; }
            set
            {
                if (value > 0)
                {
                    _height = value;
                }
            }
        }
        public Triangle() { }
        public Triangle(double base_, double side1, double side2, double height)
        {
            Base = base_;
            Side1 = side1;
            Side2 = side2;
            Height = height;
        }
        public double CalculateArea()
        {
            return (Base * Height) / 2;
        }

        public double CalculatePerimeter()
        {
            return Base + Side1 + Side2;
        }

    }
    class Trapezoid
    {
        private double _base1;
        private double _base2;
        private double _side1;
        private double _side2;
        private double _height;

        public double Base1
        {
            get { return _base1; }
            set
            {
                if (value > 0)
                {
                    _base1 = value;
                }
            }
        }

        public double Base2
        {
            get { return _base2; }
            set
            {
                if (value > 0)
                {
                    _base2 = value;
                }
            }
        }
        public double Side1
        {
            get { return _side1; }
            set
            {
                if (value > 0)
                {
                    _side1 = value;
                }
            }
        }
        public double Side2
        {
            get { return _side2; }
            set
            {
                if (value > 0)
                {
                    _side2 = value;
                }
            }
        }

        public double Height
        {
            get { return _height; }
            set
            {
                if (value > 0)
                {
                    _height = value;
                }
            }
        }

        public Trapezoid() { }

        public Trapezoid(double base1, double base2, double side1, double side2, double height)
        {
            Base1 = base1;
            Base2 = base2;
            Side1 = side1;
            Side2 = side2;
            Height = height;
        }

        public double CalculateArea()
        {
            return 0.5 * (Base1 + Base2) * Height;
        }

        public double CalculatePerimeter()
        {
            return Base1 + Base2 + Side1 + Side2;
        }


    }
}