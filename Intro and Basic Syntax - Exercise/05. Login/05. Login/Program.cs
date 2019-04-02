using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        string input = Console.ReadLine();

        string reversed = string.Empty;
        int counter = 0;
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed += input[i];
        }

        var password = Console.ReadLine();
        while (password != reversed)
        {
            counter++;
            if (counter > 3)
            {
                Console.WriteLine("User {0} blocked!", input);
                return;
            }
            Console.WriteLine("Incorrect password. Try again.");

            password = Console.ReadLine();


        }
        Console.WriteLine("User {0} logged in.", input);

    }
}

