using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Hour between 0-24 : ");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Minute between 0-60 : ");
            int m = Convert.ToInt32(Console.ReadLine());

            if ( (h > 24 || h < 0) || (m < 0 || m > 60))
            {
                Console.WriteLine("Input Error: Please Enter hour between 0-24 and Minute between 0-60");
            }
            else
            {
                Time timeInput = new Time(h, m);
                Console.WriteLine("Time Status: " + timeInput.Status());
            }

        }
    }

    public class Time
    {
        private int _hour;
        private int _minute;

        public int Hour
        {
            get { return _hour; }
            set
            {
                if(value > 0 && value < 24)
                {
                    _hour = value;
                }
            }
        }

        public int Minute
        {
            get { return _minute; }
            set
            {
                if (value > 0 && value < 60)
                {
                    _minute = value;
                }
            }
        }
        public Time() { }
        public Time(int hour, int minute)
        {
            _hour = hour;
            _minute = minute;
        }

        public string Status()
        {
            if(_hour > 12)
            {
                return "PM";
            }
            else
            {
                return "AM";
            }
        }
    }
}