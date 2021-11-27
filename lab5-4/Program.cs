using System;

namespace lab5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Лабораторная работа №5 Задание 4 (＾• ω •＾)";
            Console.ForegroundColor = ConsoleColor.DarkMagenta;


            Console.WriteLine("Введите значение координаты x1");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение координаты y1");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение координаты x2");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение координаты y2");
            int y2 = Convert.ToInt32(Console.ReadLine());


            int a = x2 - x1;
            int b = y2 - y1;

            int S = a * b;
            int P = (a + b) * 2;


            Console.WriteLine($"Площадь прямоугольника равна {S}\nПериметр прямоугольника равен {P}");


            Console.ReadKey();
        }
    }
}
