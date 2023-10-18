using System;

class Program
{
    static bool IsPrime(int num)
    {
        if (num <= 1)
        {
            return false;
        }
        for (int i = 2; i * i <= num; ++i)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static void DisplayPrimes(int start, int end)
    {
        Console.Write($"Prime numbers between {start} and {end} are: ");

        for (int i = start; i <= end; ++i)
        {
            if (IsPrime(i))
            {
                Console.Write($"{i} ");
            }
        }

        Console.WriteLine();
    }

    static void Main()
    {
        int num1, num2;

        // Input the two numbers
        Console.Write("Enter the first number: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        num2 = int.Parse(Console.ReadLine());

        // Display prime numbers between the two numbers
        DisplayPrimes(num1, num2);
    }
}
