using System;
using System.Security.Cryptography.X509Certificates;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please Enter First Point(x,y) : ");
            double point1_x = Convert.ToDouble(Console.ReadLine());
            double point1_y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter Second Point(x,y) : ");
            double point2_x = Convert.ToDouble(Console.ReadLine());
            double point2_y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter Third Point(x,y) : ");
            double point3_x = Convert.ToDouble(Console.ReadLine());
            double point3_y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter Fourth Point(x,y) : ");
            double point4_x = Convert.ToDouble(Console.ReadLine());
            double point4_y = Convert.ToDouble(Console.ReadLine());


            Distance Line1 = new Distance(point1_x, point1_y, point2_x, point2_y);
            double Line1Distance = Line1.GetDistance();
            Distance Line2 = new Distance(point3_x, point3_y, point4_x, point4_y);
            double Line2Distance = Line2.GetDistance();

            if (Line1Distance > Line2Distance)
            {
                Console.WriteLine("Line1 Larger than Line2");
            }
            else if (Line1Distance < Line2Distance)
            {
                Console.WriteLine("Line1 Smaller than Line2");
            }
            else
            {
                Console.WriteLine(" Line1 and Line2 are Equal!");
            }


        }
    }

    public class Distance
    {
        private double _point1_x;
        private double _point1_y;
        private double _point2_x;
        private double _point2_y;

        public double Point1_x
        {
            get { return _point1_x; }
            set { _point1_x = value; }
        }
        public double Point1_y
        {
            get { return _point1_y; }
            set { _point1_y = value; }
        }
        public double Point2_x
        {
            get { return _point2_x; }
            set { _point2_x = value; }
        }
        public double Point2_y
        {
            get { return _point2_y; }
            set { _point2_y = value; }
        }

        public Distance() { }
        public Distance(double point1_x, double point1_y, double point2_x, double point2_y)
        {
            _point1_x = point1_x;
            _point1_y = point1_y;
            _point2_x = point2_x;
            _point2_y = point2_y;

        }

        public double GetDistance()
        {
            return Math.Sqrt(Math.Pow(_point2_x - _point1_x, 2) + Math.Pow(_point2_y - _point1_y, 2));
        }
    }


}