using System;
using System.Security.Cryptography;

namespace MathFormula3
{
    class Test
    {
        public static void Main()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            double Result = Math.Sqrt(Math.Abs(x) + Math.Sqrt(Math.Abs(x) + Math.Sqrt(Math.Abs(x))));
            Console.WriteLine(Result);
          
        }
    }
}