using System;

class Program
{
    static void Main()
    {
        int number;

        Console.Write("Please Enter your number: ");
        number = int.Parse(Console.ReadLine());

        int digit1 = number % 10;
        int digit2 = (number / 10) % 10;
        int digit3 = (number / 100) % 10;
        int digit4 = number / 1000;

        int sum = digit1 + digit2 + digit3 + digit4;

        Console.WriteLine("Sum: " + sum);
    }
}
