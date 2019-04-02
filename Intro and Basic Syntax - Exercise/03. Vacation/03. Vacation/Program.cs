using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {

        int people = int.Parse(Console.ReadLine());
        string type = Console.ReadLine();
        string dayOfWeek = Console.ReadLine();
        double price = 0;
        double totalPrice = people * price;


        if (type.Contains("Students"))
        {
            if (dayOfWeek.Contains("Friday"))
            {
                price = 8.45;
            }
            if (dayOfWeek.Contains("Saturday"))
            {
                price = 9.80;
            }
            if (dayOfWeek.Contains("Sunday"))
            {
                price = 10.46;
            }

        }
        if (type.Contains("Business"))
        {
            if (dayOfWeek.Contains("Friday"))
            {
                price = 10.90;
            }
            if (dayOfWeek.Contains("Saturday"))
            {
                price = 15.60;
            }
            if (dayOfWeek.Contains("Sunday"))
            {
                price = 16;
            }

        }
        if (type.Contains("Regular"))
        {
            if (dayOfWeek.Contains("Friday"))
            {
                price = 15;
            }
            if (dayOfWeek.Contains("Saturday"))
            {
                price = 20;
            }
            if (dayOfWeek.Contains("Sunday"))
            {
                price = 22.50;
            }

        }
        totalPrice = people * price;

        if (type.Contains("Students") && people >= 30)
        {
            totalPrice = totalPrice - totalPrice * 0.15;
        }
        else if (type.Contains("Business") && people >= 100)
        {
            people = people - 10;
            totalPrice = people * price;
        }
        else if (type.Contains("Regular") && people >= 10 && people <= 20)
        {
            totalPrice = totalPrice - totalPrice * 0.05;
        }

        Console.WriteLine("Total price: {0:f2}", totalPrice);
    }
}
