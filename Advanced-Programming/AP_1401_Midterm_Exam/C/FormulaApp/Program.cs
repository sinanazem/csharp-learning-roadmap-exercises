using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("n: ");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("d: ");
            double d = Convert.ToDouble(Console.ReadLine());

            double result = Formula(a,n,d);
            Console.WriteLine("Result: " + result);


        }

        static double Formula(double a, double n, double d)
        {
            return a+(n-1)*d;
        } 
    }
}