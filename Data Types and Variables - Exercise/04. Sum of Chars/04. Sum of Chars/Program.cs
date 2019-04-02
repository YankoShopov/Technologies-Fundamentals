using System;
using System.Linq;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            char[] characters = new char[n];
            for (int i = 0; i < n; i++)
            {
                characters[i] = char.Parse(Console.ReadLine());
            }

            for (int i = 0; i < characters.Length; i++)
            {
                sum += characters[i];
            }
            Console.WriteLine("The sum equals: {0}", sum);
        }
    }
}

