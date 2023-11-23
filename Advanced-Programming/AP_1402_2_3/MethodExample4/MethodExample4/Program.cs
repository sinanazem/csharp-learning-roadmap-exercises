using System;
// برنامه ای بنویسید که نمره میانترم و پایان ترم را با این فرمول محاسبه کنید
// 35% * midterm + 65% * final
namespace MethodExample4
{
    class Program
    {
        static void Main(string[] args)
        {
            double midtermScore = Convert.ToDouble(Console.ReadLine());
            double finalScore = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(ClaculateTotalScore(midtermScore, finalScore));

        }
        static double ClaculateTotalScore(double midtermScore, double finalScore)
        {
            double result = (0.35 * midtermScore) + (0.65 * finalScore);
            return result;
        }
    }
}