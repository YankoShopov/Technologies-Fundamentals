using System;
using System.Collections.Generic;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> final = new List<int>();
        var letterIndex = 0;
        for (int j = 1; j <= n; j++)
        {
            int input = int.Parse(Console.ReadLine());
            var number = input.ToString();
            var numberOfDigits = 0;
            var mainDigit = 0;

            for (int i = 0; i < number.Length; i++)
            {
                numberOfDigits++;
                mainDigit = number[0] - 48;
            }
            var offset = (mainDigit - 2) * 3;

            if (mainDigit == 8 || mainDigit == 9)
            {
                offset += 1;
            }
            if (input != 1 && input != 11 && input != 111)
            {
                if (input != 0 && input != 00 && input != 0)
                {
                    letterIndex = (offset + numberOfDigits - 1);
                }
                else
                {
                    letterIndex = -65;
                }

                final.Add(letterIndex);
            }

        }


        foreach (var item in final)
        {
            Console.Write((char)(item + 97));
        }
    }



}

