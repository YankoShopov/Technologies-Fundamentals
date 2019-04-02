using System;

namespace _20192
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            if (input.Contains("USA") || input.Contains("England"))
            {
                Console.WriteLine("English");
            }
            else if (input.Contains("Spain") || input.Contains("Argentina") || input.Contains("Mexico"))
            {
                Console.WriteLine("Spanish");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}

