using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Hour: ");
            int inputTimeHour = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Minute: ");
            int inputTimeMinute = Convert.ToInt32(Console.ReadLine());

            if (inputTimeHour >= 0 && inputTimeHour < 24 && inputTimeMinute >= 0 && inputTimeMinute < 60)
            {
                TimeClass time = new TimeClass(inputTimeHour, inputTimeMinute);
                string result = time.GetAmOrPm();
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Error, Your input for Hour must be between 0-24 and for minute must be between 0-60 ! ");
            }


        }
    }
    public class TimeClass
    {
        private int _hour;
        private int _minute;

        public int Hour
        {
            get { return _hour; }
            set
            {
                if (_hour > 0 && _hour < 24)
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
                if (_minute > 0 && _minute < 60)
                {
                    _minute = value;
                }
            }
        }

        public TimeClass() { }
        public TimeClass(int hour, int minute)
        {
            _hour = hour;
            _minute = minute;
        }

        public string GetAmOrPm()
        {
            if (Hour >= 12)
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