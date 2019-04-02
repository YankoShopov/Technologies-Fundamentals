using System;

namespace _20192
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int counter = 1;
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    if (counter < input + 1)
                    {
                        counter++;
                        sum += i;
                        Console.WriteLine(i);
                    }
                    else
                        break;


                }
            }
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}

