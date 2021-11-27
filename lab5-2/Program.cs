using System;

namespace lab5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Лабораторная работа №5 Задание 2 (＾• ω •＾)";
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("Введите число А");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число В");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число С");
            int C  = Convert.ToInt32(Console.ReadLine());


            int AC = Math.Abs(C - A);
            int BC = Math.Abs(C - B);
            int summa = AC + BC;

            Console.WriteLine($"Длина отрезка АС равна {AC}");
            Console.WriteLine($"Длина отрезка ВС равна {BC}");
            Console.WriteLine($"Сумма длин отрезков равна {summa}");


            Console.ReadKey();

        }
    }
}
