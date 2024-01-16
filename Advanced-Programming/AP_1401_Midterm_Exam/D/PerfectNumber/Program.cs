using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            PerfectNumber(num);
        }

        static void PerfectNumber(int number)
        {
            if (number == 0)
            {
                Console.WriteLine("No Perfect Number!");
            }
            else
            {
                int sum = 0;
                for (int i = 1; i < number; i += 2)
                {
                    sum = sum + i;
                    if (sum == number)
                    {
                        break;
                    }
                }

                Console.WriteLine(sum);
                if (sum == number)
                {
                    Console.WriteLine("Perfect Number");
                }
                else
                {
                    Console.WriteLine("No Perfect Number!");
                }
            }
            
        }


    }
}