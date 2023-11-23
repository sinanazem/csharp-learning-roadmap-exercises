using System;
namespace MethodExample3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double result = Calculate(x);
            Console.WriteLine(result);

        }
        static double Calculate(double x_input)
        {
            double result = Math.Pow(x_input, 2) + 2 * x_input + 4;
            return result;
        }
    }
}