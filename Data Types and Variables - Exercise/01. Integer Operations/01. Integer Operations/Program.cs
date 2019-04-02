using System;

namespace _01._Integer_Operations
{
    class Program
    {
        static void Main()
        {
            int firtsNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

            int result = ((firtsNumber + secondNumber) / thirdNumber) * fourthNumber;
            Console.WriteLine(result);
        }
    }
}

