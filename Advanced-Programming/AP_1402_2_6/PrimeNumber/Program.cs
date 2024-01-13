using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintPrimeNumber obj = new PrintPrimeNumber(7,20);
            obj.Print();
        }
    }

    class PrintPrimeNumber
    {
        private int _firstNumber;
        private int _secondNumber;

        public int FirstNumber
        {
            get { return _firstNumber; }
            set { 
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
        public PrintPrimeNumber() { }
        public PrintPrimeNumber(int firstNumber, int secondNumber)
        {
            _firstNumber = firstNumber;
            _secondNumber = secondNumber;
        }

        public void Print()
        {
            for (int i = _firstNumber; i < _secondNumber; i++)
            {
                bool is_prime = true;
                for(int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        is_prime = false;
                        break;
                    }
                }
                if (is_prime && i > 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
