using System;
using System.Numerics;

namespace Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal input = decimal.Parse(Console.ReadLine());

            decimal sum = 0;
            for (int i = 1; i <= input; i++)
            {
                decimal num = decimal.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine((decimal)sum);
        }
    }
}

