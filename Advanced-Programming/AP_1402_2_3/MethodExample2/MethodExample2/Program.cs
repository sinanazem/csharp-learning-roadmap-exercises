using System;
namespace MethodExampl2
{
    class Prrgram
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            double result = Formula(x, y);
            Console.WriteLine(result);

        }
        static double Formula(double x_input, double y_input)
        {
            return Math.Sqrt(Math.Abs(x_input) + Math.Pow(y_input, 2));
        }
    }
}