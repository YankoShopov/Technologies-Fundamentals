using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = 0;
            float radius = 0;
            int height = 0;
            double volume = 0;
            string actuallName = "";
            double maxVolume = double.MinValue;
            do
            {
                n = byte.Parse(Console.ReadLine());
            } while (n < 1 || n > 10);



            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                do
                {
                    radius = float.Parse(Console.ReadLine());
                } while (radius < 1);
                do
                {
                    height = int.Parse(Console.ReadLine());
                } while (height < 1);

                volume = Math.PI * (Math.Pow(radius, 2)) * height;
                if (volume > maxVolume)
                {
                    maxVolume = volume;
                    actuallName = model;
                }
            }

            Console.WriteLine(actuallName);
        }
    }
}

