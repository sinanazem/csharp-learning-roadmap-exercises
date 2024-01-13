using System;
namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Radius of Sphere: ");
            double rSphere = Convert.ToDouble(Console.ReadLine());
            Sphere sampleSphere = new Sphere(rSphere);

            Console.WriteLine("Area : " + sampleSphere.CaculateArea());
            Console.WriteLine("Volume : " + sampleSphere.CaculateVolume());
        }
    }

    public class Sphere
    {
        private double _r;
        private double _pi = 3.1415;

        public double R
        {
            get { return _r; }
            set
            {
                if (value > 0)
                {
                    _r = value;
                }
            }
        }

        public Sphere() { }
        public Sphere(double r)
        {
            _r = r;
        }

        public double  CaculateArea()
        {
            return 4 * _pi * Math.Pow(_r,2);
        }

        public double CaculateVolume()
        {
            return  _pi * Math.Pow(_r, 3) * (4.0/3.0);
        }
    } 
}