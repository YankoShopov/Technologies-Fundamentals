using System;

namespace _20192
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                var result = input * i;
                Console.WriteLine("{0} X {1} = {2}", input, i, result);

            }

        }
    }
}
