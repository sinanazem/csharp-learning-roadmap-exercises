using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("please enter second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            OddNumber obj = new OddNumber(firstNumber, secondNumber);
            obj.Print();
        }
    }
    public class OddNumber
    {
        private int _firstNumber;
        private int _secondNumber;

        public int FirstNumber
        {
            get { return _firstNumber; }
            set
            {
                if (value > 0)
                {
                    _firstNumber = value;
                }
            }
        }
        public int SecondNumber
        {
            get { return _secondNumber; }
            set
            {
                if (value > 0)
                {
                    _secondNumber = value;
                }
            }
        }

        public OddNumber() { }
        public OddNumber(int firstNumber, int secondNumber)
        {
            _firstNumber = firstNumber; 
            _secondNumber = secondNumber;
        }

        public void Print()
        {
            for (int i= _firstNumber;i< _secondNumber; i++)
            {
                if (i%2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}