using System;

namespace Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string firts = Console.ReadLine();
            string second = Console.ReadLine();
            string delimiter = Console.ReadLine();
            Console.WriteLine($"{firts}{delimiter}{second}");
        }
    }
}

