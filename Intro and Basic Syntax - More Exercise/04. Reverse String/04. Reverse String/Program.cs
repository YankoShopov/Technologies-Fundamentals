using System;
using System.Collections.Generic;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        string input = Console.ReadLine();
        string reversed = string.Empty;
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed += input[i];
        }
        foreach (var item in reversed)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }

}
