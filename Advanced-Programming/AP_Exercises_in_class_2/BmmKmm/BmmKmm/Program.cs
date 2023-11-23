using System;

class Program
{
    static void Main()
    {
        // دریافت دو عدد از ورودی
        Console.Write("عدد اول: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("عدد دوم: ");
        int num2 = int.Parse(Console.ReadLine());

        // فراخوانی متد کوچک‌ترین مضرب مشترک و چاپ نتیجه
        Console.WriteLine($"کوچک‌ترین مضرب مشترک: {FindLCM(num1, num2)}");

        // فراخوانی متد بزرگ‌ترین مقسوم‌علیه مشترک و چاپ نتیجه
        Console.WriteLine($"بزرگ‌ترین مقسوم‌علیه مشترک: {FindGCD(num1, num2)}");
    }

    // متد برای پیدا کردن کوچک‌ترین مضرب مشترک
    static int FindLCM(int a, int b)
    {
        return (a * b) / FindGCD(a, b);
    }

    // متد برای پیدا کردن بزرگ‌ترین مقسوم‌علیه مشترک
    static int FindGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
