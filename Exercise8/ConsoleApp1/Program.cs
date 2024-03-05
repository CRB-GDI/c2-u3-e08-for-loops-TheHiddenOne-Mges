using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please set a Value");
            int  value = int.Parse(Console.ReadLine());

            for (int i = 0; i <=value; i+=2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("how many asterisks do you need");
            int asterrisksNeeded = int.Parse(Console.ReadLine());
            for (int g = 1; g <= asterrisksNeeded; g++)
            {
                Console.Write("*");
            }
        }
    }
}