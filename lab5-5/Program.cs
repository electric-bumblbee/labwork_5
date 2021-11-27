using System;

namespace lab5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Лабораторная работа №5 Задание 5 (＾• ω •＾)";
            Console.ForegroundColor = ConsoleColor.DarkRed;
            //Console.BackgroundColor = ConsoleColor.DarkGreen;

            
            Console.WriteLine("Введите значение координаты x1");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение координаты у1");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение координаты x2");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение координаты у2");
            int y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение координаты x3");
            int x3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение координаты у3");
            int y3 = Convert.ToInt32(Console.ReadLine());


            int S = ((x2 - x1)*(y3 - y1) - (x3 - x1)*(y2 - y1))/2;
            double P = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));


            Console.WriteLine($"Площадь треугольника равна {S}\nПериметр треуголоника равен {P}");


            Console.ReadKey();
        }
    }
}
