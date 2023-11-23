using System;
// barnamei ba estefadeh as sakhtar method benvisid ke yek araye ba size 10 varred kardeh max min ra peyda karde hasel jam tafrigh bargardanad

namespace Test
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(3, 60);
            }
            SumSub(arr);
        }
        static void SumSub(int[] arr)
        {
            // max
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            // min
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            Console.WriteLine("Max+Min= " + (max + min));
            Console.WriteLine("Max-Min= " + (max - min));
        }

    }

}