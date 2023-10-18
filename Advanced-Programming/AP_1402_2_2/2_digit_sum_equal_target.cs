using System;

class Program
{
    static int DigitSum(int number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }

    static void Main()
    {
        int firstNumber, secondNumber, targetSum;

        Console.Write("Enter the first number: ");
        firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        secondNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter the target sum: ");
        targetSum = int.Parse(Console.ReadLine());

        if (firstNumber > secondNumber)
        {
            Console.WriteLine("Error: The first number should be less than or equal to the second number.");
            Environment.Exit(1);
        }

        Console.WriteLine($"Numbers with digit sum equal to {targetSum} between {firstNumber} and {secondNumber}:");

        for (int i = firstNumber; i <= secondNumber; ++i)
        {
            if (DigitSum(i) == targetSum)
            {
                Console.WriteLine(i);
            }
        }
    }
}
