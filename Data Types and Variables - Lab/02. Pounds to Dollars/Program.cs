using System;

namespace Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:f3}", input * 1.31);
        }
    }
}

