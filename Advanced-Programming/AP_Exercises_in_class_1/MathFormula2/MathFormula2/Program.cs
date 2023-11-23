using System;



namespace MathFormula
{
    class Test
    {
        public static void Main()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            double Result = Math.Sqrt(Math.Pow(Math.Abs(x-y),Math.Abs(y)));
            Console.WriteLine(Result);


        }
    }
}

