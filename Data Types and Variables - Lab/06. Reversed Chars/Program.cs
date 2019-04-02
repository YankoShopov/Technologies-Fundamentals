using System;

namespace Reversed_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chars = new char[3];
            for (int i = 0; i < 3; i++)
            {
                chars[3 - i - 1] = char.Parse(Console.ReadLine());

            }
            foreach (var item in chars)
            {
                Console.Write(item + " ");
            }
        }
    }
}

