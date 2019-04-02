using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main()
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = 0;

            do
            {
                courses++;
                numberOfPeople = numberOfPeople - capacity;

            } while (numberOfPeople > 0);
            Console.WriteLine(courses);
        }
    }
}

