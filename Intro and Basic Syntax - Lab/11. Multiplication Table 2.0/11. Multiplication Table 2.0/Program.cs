using System;

namespace _20192
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());

            for (int i = input2; i <= 10; i++)
            {
                var result = input * i;
                if (input2 <= 10)
                {
                    Console.WriteLine("{0} X {1} = {2}", input, i, result);
                }

            }
            if (input2 > 10)
            {
                var result = input * input2;
                Console.WriteLine("{0} X {1} = {2}", input, input2, result);
            }

        }
    }
}

