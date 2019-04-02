using System;
using System.Collections.Generic;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        string input = Console.ReadLine();
        double money = 0;

        double.TryParse(input, out money);
        var totalMoney = money;
        do
        {
            input = Console.ReadLine();

            if (input.Contains("OutFall 4") || input.Contains("CS: OG") || input.Contains("Zplinter Zell") || input.Contains("Honored 2") || input.Contains("RoverWatch") || input.Contains("RoverWatch Origins Edition"))
            {
                if (input == "OutFall 4")
                {
                    money = money - 39.99;
                    if (money >= 0)
                    {
                        Console.WriteLine("Bought {0}", input);
                    }
                    if (money < 0)
                    {
                        Console.WriteLine("Too Expensive");
                        money = money + 39.99;
                    }
                }
                if (input == "CS: OG")
                {
                    money = money - 15.99;
                    if (money >= 0)
                    {
                        Console.WriteLine("Bought {0}", input);
                    }
                    if (money < 0)
                    {
                        Console.WriteLine("Too Expensive");
                        money = money + 15.99;
                    }
                }
                if (input == "Zplinter Zell")
                {
                    money = money - 19.99;
                    if (money >= 0)
                    {
                        Console.WriteLine("Bought {0}", input);
                    }
                    if (money < 0)
                    {
                        Console.WriteLine("Too Expensive");
                        money = money + 19.99;
                    }
                }
                if (input == "Honored 2")
                {
                    money = money - 59.99;
                    if (money >= 0)
                    {
                        Console.WriteLine("Bought {0}", input);
                    }
                    if (money < 0)
                    {
                        Console.WriteLine("Too Expensive");
                        money = money + 59.99;
                    }
                }
                if (input == "RoverWatch")
                {
                    money = money - 29.99;
                    if (money >= 0)
                    {
                        Console.WriteLine("Bought {0}", input);
                    }
                    if (money < 0)
                    {
                        Console.WriteLine("Too Expensive");
                        money = money + 29.99;
                    }
                }
                if (input == "RoverWatch Origins Edition")
                {
                    money = money - 39.99;
                    if (money >= 0)
                    {
                        Console.WriteLine("Bought {0}", input);
                    }
                    if (money < 0)
                    {
                        Console.WriteLine("Too Expensive");
                        money = money + 39.99;
                    }
                }

            }
            else
            {
                if (input != "Game Time")
                {
                    Console.WriteLine("Not Found");
                }
            }


        } while (input != "Game Time");
        if (money > 0)
        {
            Console.WriteLine("Total spent: ${0:f2}. Remaining: ${1:f2}", totalMoney - money, money);
        }
        else
        {
            Console.WriteLine("Out of money!");
        }

    }



}

