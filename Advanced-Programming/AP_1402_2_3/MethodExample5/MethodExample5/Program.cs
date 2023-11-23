using System;

namespace MethodExample5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            
            if (num % 2 == 0)
            {
                Even(num);
            }
            else
            {
                Odd(num);
            }
        }
        static void Even(int number)
        {
            int sum = 0, mul = 1;
            for (int i = 2; i <= number; i+=2)
            {
                sum += i;
                mul *= i;
            }
            Console.WriteLine(sum);
            Console.WriteLine(mul);
        }
        static void Odd(int number)
        {
            int sum = 0, mul = 1;
            for (int i = 1; i <= number; i+=2)
            {
                sum += i;
                mul *= i;
            }
            Console.WriteLine(sum);
            Console.WriteLine(mul);
        }
    }
}