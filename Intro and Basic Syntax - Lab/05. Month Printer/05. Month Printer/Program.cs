using System;

namespace _20192
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());

            var days = new[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };


            for (int i = 0; i < days.Length; i++)
            {
                if (input == i + 1)
                {
                    Console.WriteLine(days[i]);
                }


            }
            if (input < 1 || input > 12)
            {
                Console.WriteLine("Error!");
            }

        }
    }
}

