using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        float money = float.Parse(Console.ReadLine());
        int students = int.Parse(Console.ReadLine());
        float sabres = float.Parse(Console.ReadLine());
        float robes = float.Parse(Console.ReadLine());
        float belts = float.Parse(Console.ReadLine());


        double totalSabre = Math.Ceiling((students + 0.10 * students)) * sabres;
        double totalRobes = robes * students;

        double beltFree = 0;

        beltFree = Math.Floor(students / 6.0);


        double totalBelts = belts * (students - beltFree);


        double totalMoney = totalSabre + totalRobes + totalBelts;

        if (totalMoney > money)
        {
            double diff = totalMoney - money;
            Console.WriteLine("Ivan Cho will need {0:f2}lv more.", diff);

        }
        else
        {
            Console.WriteLine("The money is enough - it would cost {0:f2}lv.", totalMoney);
        }
    }
}

