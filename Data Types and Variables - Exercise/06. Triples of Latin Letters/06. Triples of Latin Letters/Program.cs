using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (char i = 'a'; i < (char)n + 97; i++)
            {
                for (char j = 'a'; j < (char)n + 97; j++)
                {
                    for (char k = 'a'; k < (char)n + 97; k++)
                    {
                        Console.WriteLine("{0}{1}{2}", i, j, k);
                    }
                }
            }
        }
    }
}

