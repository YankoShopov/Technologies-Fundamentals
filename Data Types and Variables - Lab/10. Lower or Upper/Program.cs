using System;

namespace Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());

            for (int i = 65; i <= 90; i++)
            {
                if (i == input)
                {
                    Console.WriteLine("upper-case");

                }
            }
            for (int i = 97; i <= 122; i++)
            {
                if (i == input)
                {
                    Console.WriteLine("lower-case");

                }
            }
        }
    }
}
