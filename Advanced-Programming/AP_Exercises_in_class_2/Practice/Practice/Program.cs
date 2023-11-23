// ba estefadeh az saghtar method add az karbar begirad on ra bar mabnayeh 2 borde va da method asli chap kon

using System;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Reverse(ToTwoDecimal(number)));
            Console.ReadKey();


        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static string ToTwoDecimal(int num) {
            string binarybox = "";
  
            while (num > 0)
            {
                int remainder = num % 2;
                binarybox += remainder;
                num /= 2;
            }
            return binarybox;

    }
        }
        



    }