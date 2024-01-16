using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter Triangle Side1 : ");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("please enter Triangle Side2 : ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("please enter Triangle Side3 : ");
            double side3 = Convert.ToDouble(Console.ReadLine());

            if (CheckTriangle(side1, side2, side3))
            {
                string result = TriangleType(side1, side2, side3);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Not Create Triangle!");
            }

        }

        static bool CheckTriangle(double side1, double side2, double side3)
        {
            return (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1);
        }
        static string TriangleType(double side1, double side2 , double side3)
        {
            if (side1 == side2 && side2 == side3)
            {
                return "Motasavi azlae";
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                return "Motasavi saghain";
            }
            else if (side1 == Math.Sqrt(Math.Pow(side2, 2) + Math.Pow(side3, 2)) || side2 == Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side3, 2)) || side3 == Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2)))
            {
                return "Ghaem zavieh";
            }
            else
            {
                return "mokhtalef azlae";
            }
        }
    }
}