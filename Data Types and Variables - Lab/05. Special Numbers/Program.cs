using System;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                if (i < 10)
                {
                    if (i == 5 || i == 7)
                    {
                        Console.WriteLine($"{i} -> True");
                    }
                    else
                    {
                        Console.WriteLine($"{i} -> False");
                    }
                }
                else if (i > 9)
                {
                    int num = i;
                    while (num > 0)
                    {
                        sum += num % 10;
                        num = num / 10;
                    }

                    if (sum == 5 || sum == 7 || sum == 11)
                    {
                        Console.WriteLine($"{i} -> True");

                    }
                    else
                    {
                        Console.WriteLine($"{i} -> False");
                    }
                    sum = 0;
                }
            }
        }
    }
}

