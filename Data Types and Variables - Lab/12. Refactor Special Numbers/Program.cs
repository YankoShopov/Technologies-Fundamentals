using System;

namespace Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit = int.Parse(Console.ReadLine());
            int sum = 0;
            bool isSpecialNumber = false;

            for (int i = 1; i <= digit; i++)
            {
                int actuallNumber = i;
                while (actuallNumber > 0)
                {
                    sum += actuallNumber % 10;
                    actuallNumber = actuallNumber / 10;
                }
                isSpecialNumber = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", i, isSpecialNumber);
                sum = 0;

            }

        }
    }
}

