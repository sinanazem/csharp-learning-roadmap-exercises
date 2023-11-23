using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] movies = new string[3] {"God Father", "Rain Man", "Red"};
            List<double> ranks = new List<double>();
            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine("please insert your (1-10) for " + movies[i] + ": ");
                double rank = Convert.ToDouble(Console.ReadLine());
                ranks.Add(rank);

            }

            Console.WriteLine("AVG is: " + Avg(ranks));
        }
        public static  double Avg(List<double> userRanks)
        {
            double sum = 0;
            for (int i = 0; i < userRanks.Count; i++)
            {
                sum += userRanks[i];

            }
            return sum / userRanks.Count;

        }

    }
}