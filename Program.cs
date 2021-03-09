using System;

namespace SF3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name!");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age!");
            byte age = (byte) int.Parse(Console.ReadLine());

            Console.WriteLine("Your name is {0}!! But your age is {1}!!!", name, age);

            Console.ReadKey();
        }
    }
}
