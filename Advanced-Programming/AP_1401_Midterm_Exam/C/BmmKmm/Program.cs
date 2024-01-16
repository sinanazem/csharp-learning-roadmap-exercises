using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter First Number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Second Number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                int resultBmm = Bmm(secondNumber, firstNumber);
                int resultKmm = Kmm(secondNumber, firstNumber);
                Console.WriteLine("Bmm is: " + resultBmm);
                Console.WriteLine("Kmm is: " + resultKmm);
            }
            else
            {
                int resultBmm = Bmm(firstNumber, secondNumber);
                int resultKmm = Kmm(firstNumber, secondNumber);
                Console.WriteLine("Bmm is: " + resultBmm);
                Console.WriteLine("Kmm is: " + resultKmm);
            }
        }

        static int Bmm(int num1, int num2)
        {
            int result = 1;

            for (int i = 1; i < num2; i++)
            {
                if (num1 % i == 0 && num2%i == 0)
                {
                    result = i;
                }
            }
            return result;
        }

        static int Kmm(int num1, int num2)
        {
            return num1 * num2 / Bmm(num1, num2);
        }
    }
}