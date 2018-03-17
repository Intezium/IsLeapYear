using System;

namespace IsLeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("===>[Является ли год високосным]<===");
                Console.Write("\nВведите год: ");

                try
                {
                    int year = int.Parse(Console.ReadLine());

                    IsLeapYear(year);
                }
                catch (FormatException) { Console.WriteLine("\nНекорректный год!"); }

                Console.WriteLine("\nEnter - Проверить еще");
                Console.WriteLine("Esc - Выйти");

                ConsoleKey inputKey = Console.ReadKey().Key;

                if (inputKey == ConsoleKey.Enter)
                    continue;
                else if (inputKey == ConsoleKey.Escape)
                    break;
            }
        }

        static void IsLeapYear(int year)
        {
            if (year > 0)
            {
                if ((year % 4 == 0) && (year % 100 != 0 || year % 400 == 0))
                    Console.WriteLine("\nГод {0} високосный", year);
                else
                    Console.WriteLine("\nГод {0} не високосный", year);
            }
            else
                Console.WriteLine("\nГод должен быть больше нуля!");
        }
    }
}
