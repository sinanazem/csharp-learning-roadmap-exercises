using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Time(4595);
        }

        static void Time(int number)
        {
            int sec = number % 60;
            int sec_kh = number / 60;
            int min = sec_kh % 60;
            int min_kh = sec_kh / 60;
            int hour = min_kh % 60;
            int day = min_kh / 60;

            Console.WriteLine("Day: " + day + " hour: " + hour + " min: " + min + " sec: " + sec);
        }
    }
}