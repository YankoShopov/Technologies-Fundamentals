using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        string input = Console.ReadLine();
        double money = 0;
        double.TryParse(input, out money);
        double totalMoney = 0;
        if (money != 0.1 && money != 0.2 && money != 0.5 && money != 1 && money != 2)
        {
            Console.WriteLine("Cannot accept {0}", money);

        }
        else
        {
            totalMoney += money;

        }

        do
        {

            if (input != "Start" && double.TryParse(input, out money) == true && input != "End")
            {
                input = Console.ReadLine();

                double.TryParse(input, out money);
                if (money != 0.1 && money != 0.2 && money != 0.5 && money != 1 && money != 2 && input != "Start")
                {
                    Console.WriteLine("Cannot accept {0}", money);
                }
                else if (input != "Start")
                {
                    totalMoney += money;

                }

            }
            if ((input == "Start" || double.TryParse(input, out money) == false) && input != "End")
            {
                input = Console.ReadLine();
                if (input != "Nuts" && input != "Water" && input != "Crisps" && input != "Soda" && input != "Coke")
                {
                    if (input != "End")
                        Console.WriteLine("Invalid product");
                }
                if (input.Contains("Nuts"))
                {
                    totalMoney = totalMoney - 2;
                    if (totalMoney < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        totalMoney = totalMoney + 2;
                    }
                    else
                    {
                        Console.WriteLine("Purchased {0}", input.ToLower());
                    }
                }
                if (input.Contains("Water"))
                {
                    totalMoney = totalMoney - 0.7;
                    if (totalMoney < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        totalMoney = totalMoney + 0.7;
                    }
                    else
                    {
                        Console.WriteLine("Purchased {0}", input.ToLower());
                    }
                }
                if (input.Contains("Crisps"))
                {
                    totalMoney = totalMoney - 1.5;
                    if (totalMoney < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        totalMoney = totalMoney + 1.5;
                    }
                    else
                    {
                        Console.WriteLine("Purchased {0}", input.ToLower());
                    }
                }
                if (input.Contains("Soda"))
                {
                    totalMoney = totalMoney - 0.8;
                    if (totalMoney < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        totalMoney = totalMoney + 0.8;
                    }
                    else
                    {
                        Console.WriteLine("Purchased {0}", input.ToLower());
                    }
                }
                if (input.Contains("Coke"))
                {
                    totalMoney = totalMoney - 1;
                    if (totalMoney < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        totalMoney = totalMoney + 1;
                    }
                    else
                    {
                        Console.WriteLine("Purchased {0}", input.ToLower());
                    }
                }

            }

        }
        while (input != "End");





        Console.WriteLine("Change: {0:f2}", totalMoney);
    }
}

