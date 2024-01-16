using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please insert Year:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please insert Month:");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please insert Day:");
            int d = Convert.ToInt32(Console.ReadLine());

            string result = MajicYear(y,m,d);
            Console.WriteLine(result);
        }

        static string MajicYear(int year, int month, int day)
        {
            string isMajic = "No Majic :(";
            year = year % 100;
            if (month*day == year)
            {
                isMajic = "Majic Year!!!!";
            }

            return isMajic;
        }
    }
}