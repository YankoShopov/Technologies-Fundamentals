using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int totalCapacity = 255;
            int actallCapacity = 0;
            for (int i = 1; i <= n; i++)
            {
                string num = Console.ReadLine();
                int input = 0;
                int.TryParse(num, out input);
                if (int.TryParse(num, out input) == true)
                {
                    actallCapacity += input;
                    if (actallCapacity <= totalCapacity)
                    {

                    }
                    else
                    {
                        Console.WriteLine("Insufficient capacity!");
                        actallCapacity = actallCapacity - input;
                    }
                }
                else
                {
                    i--;
                }

            }
            if (actallCapacity <= totalCapacity)
            {
                Console.WriteLine(actallCapacity);
            }
        }
    }
}

