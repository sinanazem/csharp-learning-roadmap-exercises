using System;
//برنامه ای بنویسید که اطلاعات جعبه ای از قبیل طول و عرض و ارتفاع را از ورودی دریافت کرده و حجم این جعبه را مشخص کند
namespace MethodExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs_name = new string[3] { "L", "H", "W" };
            double[] measureInputs  = new double[inputs_name.Length];
            
            for (int i = 0; i < inputs_name.Length; i++)
            {
                Console.WriteLine(inputs_name[i]);
                measureInputs[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Volume is: " + CalculateVolume(measureInputs[0], measureInputs[1], measureInputs[2]));
            
        }
        static double CalculateVolume(double num1, double num2, double num3)
        {
            return num1 * num2 * num3;
        }
    }
}