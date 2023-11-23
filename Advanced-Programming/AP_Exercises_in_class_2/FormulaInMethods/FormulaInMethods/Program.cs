//using System;

//namespace Project
//{
//    class Test
//    {
//        static void Main(string[] args) { 


//        }
//    }
//}

using System;

class Program
{
    static void Main()
    {
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());

        int gcd = bmm(num1, num2);
        int lcm = kmm(num1, num2);

        Console.WriteLine("bmm = " + gcd);
        Console.WriteLine("kmm = " + lcm);
    }

    private static int bmm(int a, int b)
    {
        int num = 1;
        for (int i = 1; i <= a && i <= b; i++)
        {
            if (a % i == 0 && b % i == 0)
            {
                num = i;
            }
        }
        return num;
    }
    private static int kmm(int a, int b)
    {
        int kmm = (a * b) / bmm(a, b);
        return kmm;
    }
}