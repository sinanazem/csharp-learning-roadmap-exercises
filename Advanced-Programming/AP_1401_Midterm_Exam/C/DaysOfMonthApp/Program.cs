using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter number of month: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Month(num));
        }

        static string Month(int monthNumber)
        {
            if (monthNumber > 12 || monthNumber < 1)
            {
                return "Not Valid Input! Number of month must be between 1-12!";
            }
            else if (monthNumber > 0 && monthNumber < 7)
            {
                return "31 days";
            }
            else if(monthNumber >= 7 && monthNumber < 12)
            {
                return "30 days";
            }
            else
            {
                return "29 days or 30 days";
            }
        }
    }
}