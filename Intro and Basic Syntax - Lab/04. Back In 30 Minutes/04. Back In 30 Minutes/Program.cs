using System;

namespace _20192
{
    class Program
    {
        static void Main(string[] args)
        {

            int hours = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());


            var actuallMin = min + 30;
            var actuallHours = 0;
            if (actuallMin > 59)
            {
                hours = hours + 1;
                actuallMin = actuallMin - 60;
            }
            if (hours > 23)
            {
                actuallHours = hours - 24;
            }
            else
                actuallHours = hours;

            Console.WriteLine("{0}:{1:D2}", actuallHours, actuallMin);



        }
    }
}

