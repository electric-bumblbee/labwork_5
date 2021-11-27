using System;

namespace lab5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title ="Лабораторная работа №5 Задание 3 (＾• ω •＾)";
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("Точка С находится между точками А и В");

            Console.WriteLine("Введите число А");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число С");
            int C  = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число В");
            int B = Convert.ToInt32(Console.ReadLine());
           
            int AC = Math.Abs(C - A);
            int BC = Math.Abs(B - C);
            int l = AC * BC;

            Console.WriteLine($"Произведение отрезков АС и ВС равно {l}");

            Console.ReadKey();
        }
    }
}
