using System;

namespace Project
{
    class Program
    {
        static void Main()
        {
            string[] inputs = new string[3] { "L", "W", "H" };
            double[] mesurements_input = new double[3];
            
            for (int i = 0; i < inputs.Length; i++) {
                Console.WriteLine(inputs[i]);
                mesurements_input[i] = Convert.ToDouble(Console.ReadLine());


            }
            Console.WriteLine(CalculateVolume(mesurements_input[0], mesurements_input[1], mesurements_input[2]));
        }
        static double CalculateVolume(double num1, double num2, double num3)
        {
            return num1 * num2 * num3;
        }

    }
}