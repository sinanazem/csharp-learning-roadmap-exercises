using System;



namespace MathFormula
{
    class Test
    {
        public static void Main()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            double Result =  Math.Sqrt(Math.Cos(x) * Math.Abs(y - x) + Math.Sqrt(Math.Sin(Math.Abs(x))));
            Console.WriteLine(Result);


        }
    }
}
