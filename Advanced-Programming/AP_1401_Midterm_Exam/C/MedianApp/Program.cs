using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] newNums = Median(nums);

            for (int i = 0;i < newNums.Length;i++)
            {
                Console.WriteLine(newNums[i]);
            }

        }

        static int[] Median(int[] nums)
        {
            for (int i = 1; i <= 8; i++)
            {
                nums[i] = (nums[i - 1] + nums[i] + nums[i + 1]) / 3;
            }
            return nums;
        }
    }
}