using System;
using System.Drawing;

namespace OOP
{
    class Program
    {
        static void Main()
        {
            Manager mng = new Manager();
            mng.Name = "John";
            Client cl1 = mng.AddClient("Sina");
            cl1.Buy("book");
            cl1.Buy("mobile");
            cl1.Buy("mackbook");

            Console.WriteLine(cl1.Name + " Points is: " + cl1.GetPoint());

        }
    }
    public class Client
    {
        public string Name;
        private int point = 0;
        
        public int GetPoint()
        {
            return point;
        }

        public void Buy(string product)
        {
            point++;
        }
    }
    public class Manager
    {
        public string Name;

        public Client AddClient(string clientName)
        {
            Client cl1 = new Client();
            cl1.Name = clientName;
            return cl1;
        }
    }
}