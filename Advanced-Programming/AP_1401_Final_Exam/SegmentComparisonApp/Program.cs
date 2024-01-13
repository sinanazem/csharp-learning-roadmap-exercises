using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            SegmentComparison Line1 = new SegmentComparison(1, 1, 8, 8);
            double line1Length = Line1.Calculate();
            SegmentComparison Line2 = new SegmentComparison(3, 3, 4, 4);
            double line2Length = Line2.Calculate();

            Console.WriteLine("Line 1: " + line1Length + " and " + "Line 2: " + line2Length);
        }
    }

    public class SegmentComparison
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

        public SegmentComparison() { }
        public SegmentComparison(double point1_x, double point1_y, double point2_x, double point2_y)
        {
            _point1_x = point1_x;
            _point1_y = point1_y;
            _point2_x = point2_x;
            _point2_y = point2_y;
        }

        public double Calculate()
        {
            return Math.Sqrt(Math.Pow(_point2_x - _point1_x, 2) + Math.Pow(_point2_y - _point1_y,2));
        }
    }
}