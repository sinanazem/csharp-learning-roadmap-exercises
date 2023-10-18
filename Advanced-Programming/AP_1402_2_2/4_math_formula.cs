using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a value for x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        double y = Math.Sqrt(Math.Abs(x) + Math.Sqrt(Math.Abs(x) + Math.Abs(x)));
        Console.WriteLine(y);
    }
}
