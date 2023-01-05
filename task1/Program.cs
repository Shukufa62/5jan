using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Console.WriteLine(text.HasDigit());
            Console.WriteLine(text.FixSpace());
        }
    }
}

