using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your Number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Reverse is: " + Reverse(n));
            Console.WriteLine("Number of Digit is: " + NumberDigit(n));
        }
        static int Reverse(int n)
        {
            int result = 0;
            while(n > 0)
            {
                result = result * 10 + n % 10;
                n/=10;
            }
            return result;
        }
        static int NumberDigit(int n)
        {
            int counter = 0;
            while (n > 0)
            {
                n /= 10;
                counter++;
            }
            return counter;
        }
    }
}