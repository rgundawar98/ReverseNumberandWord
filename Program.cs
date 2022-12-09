using System;

namespace ReverseNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Please enter a number");
            int value = Convert.ToInt32(Console.ReadLine());
            ReverseNumber.ReverseProgram(value);
            Console.ReadLine();

        }
    }
}
