using System;

namespace Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chars = new char[3];

            for (int i = 0; i < 3; i++)
            {
                chars[i] = char.Parse(Console.ReadLine());
            }

            foreach (var item in chars)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}

