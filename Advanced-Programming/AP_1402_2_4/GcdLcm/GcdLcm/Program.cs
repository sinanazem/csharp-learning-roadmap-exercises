using System;
// برنامه ای با استفاده از دو متد بنویسید که دو عدد از ورودی دریافت کرده و در آن دو متد جداگانه "کوچک ترین مضرب مشترک" و "بزرگ ترین مقسوم علیه مشترک" را جداگانه حساب و در خروجی چاپ کند.



namespace GcdLcm
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("GCD is: " + GCD(firstNumber, secondNumber));
            Console.WriteLine("LCM is: " + LCM(firstNumber, secondNumber));

        }
        static int GCD(int num1, int num2)
        {

            while (num2 != 0)
            {
                int temp = num2;
                num2 = num1 % num2;
                num1 = temp;
            }
            return num1;
        }
        static int LCM(int num1, int num2)
        {
            int max = Math.Max(num1, num2);
            for (int i = max; ; i += max)
            {
                if (i % num1 == 0 && i % num2 == 0)
                    return i;
            }

        }
    }
}