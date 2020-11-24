using System;

namespace _1._7
{
    class Program
    {
        //author: Benjamin Daniel Morgan
        //date: 04/12/17 

        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Clear();

            string input;
            string planetname;
            double radius;
            const double Pi = 3.142;
            double Volume;


            Console.WriteLine("Hello, What Planet are you from?");
            planetname = Console.ReadLine();

            Console.Write("What is the planet's radius?:\t");
            input = Console.ReadLine();
            radius = Convert.ToDouble(input);

            Volume = 4.0 / 3 * Pi * Math.Pow(radius, 3);
            Volume = Math.Round(Volume, 2);

            Console.WriteLine("Planet: " + planetname + "\t\t\tRadius: " + radius + " km");
            Console.WriteLine("\t\tVolume of" + planetname);
            Console.WriteLine("\t\t=======================");
            Console.WriteLine("\t\t" + Volume + "cubic kilometres");
        }
    }
}
