using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Days.Wednesday);
            Console.WriteLine((int)Days.Tuesday);

            Console.WriteLine();
            int weather = int.Parse(Console.ReadLine());

            if (weather < (int)Weather.Cold)
            {
                Console.WriteLine("It's freezing!");
            }
            else if (weather >= (int)Weather.Cold && weather < (int)Weather.Hot)
            {
                Console.WriteLine("It's a nice and cool day!");
            }
            else
            {
                Console.WriteLine("I'm melting!");
            }

            Console.ReadLine();
        }
    }

    enum Days
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    enum Weather
    {
        Cold = 5,
        Warm,
        Hot = 30
    }
}
