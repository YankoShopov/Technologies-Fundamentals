using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        int[] number = new int[3];
        int[] reversed = new int[number.Length];
        for (int i = 0; i < 3; i++)
        {
            number[i] = int.Parse(Console.ReadLine());

        }
        Array.Sort(number);
        for (int i = 0; i < number.Length; i++)
        {
            reversed[i] = number[number.Length - 1 - i];
        }

        foreach (var item in reversed)
        {
            Console.WriteLine(item);
        }
    }
}

