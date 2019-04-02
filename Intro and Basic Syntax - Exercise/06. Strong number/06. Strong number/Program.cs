using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        string number = Console.ReadLine();
        var real = 0;
        int.TryParse(number, out real);

        int fac = 1;
        int input = 0;
        int sum = 0;
        for (int i = 0; i < number.Length; i++)
        {
            input = number[i] - 48;
            for (int j = input; j > 0; j--)
            {
                fac *= j;

            }
            if (input != 0)
            {
                sum += fac;
            }
            else
            {
                sum += 1;
            }
            fac = 1;
        }

        if (sum == real)
        {
            Console.WriteLine("yes");

        }
        else
        {
            Console.WriteLine("no");
        }


    }
}

