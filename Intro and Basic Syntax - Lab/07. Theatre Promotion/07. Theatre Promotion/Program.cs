using System;

namespace _20192
{
    class Program
    {
        static void Main(string[] args)
        {

            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            if (typeOfDay != "Weekday" && typeOfDay != "Weekend" && typeOfDay != "Holiday" || (age < 0 || age > 122))
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Price(typeOfDay, age);
            }
        }

        static void Price(string day, int age)
        {
            int price = 0;
            if (day.Contains("Weekday"))
            {
                if (age >= 0 && age <= 18)
                {
                    price = 12;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 18;
                }
                else if (age > 64 && age <= 122)
                {
                    price = 12;
                }
            }
            if (day.Contains("Weekend"))
            {
                if (age >= 0 && age <= 18)
                {
                    price = 15;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 20;
                }
                else if (age > 64 && age <= 122)
                {
                    price = 15;
                }
            }
            if (day.Contains("Holiday"))
            {
                if (age >= 0 && age <= 18)
                {
                    price = 5;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 12;
                }
                else if (age > 64 && age <= 122)
                {
                    price = 10;
                }
            }
            Console.WriteLine("{0}$", price);
            return;
        }
    }
}

