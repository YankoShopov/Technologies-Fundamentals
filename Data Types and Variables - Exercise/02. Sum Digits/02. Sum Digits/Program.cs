using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = number.ToString().Length;
            while (count > 0)
            {
                sum += number % 10;
                number = number / 10;
                count--;
            }
            Console.WriteLine(sum);
        }
    }
}

