using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        int lostGames = int.Parse(Console.ReadLine());
        float headset = float.Parse(Console.ReadLine());
        float mouse = float.Parse(Console.ReadLine());
        float keyboard = float.Parse(Console.ReadLine());
        float display = float.Parse(Console.ReadLine());

        var headsetcount = 0;
        var mausecount = 0;
        var keyboardcount = 0;
        var displaycount = 0;

        for (int i = 1; i <= lostGames; i++)
        {
            if (i % 2 == 0)
            {
                headsetcount++;

            }
            if (i % 3 == 0)
            {
                mausecount++;

            }
            if (i % 2 == 0 && i % 3 == 0)
            {
                keyboardcount++;
            }




        }

        if (keyboardcount >= 2)
        {
            displaycount = keyboardcount / 2;

        }
        float totalexpenses = (headset * headsetcount) + (mouse * mausecount) + (keyboard * keyboardcount) + (display * displaycount);

        Console.WriteLine("Rage expenses: {0:f2} lv.", totalexpenses);
    }
}

