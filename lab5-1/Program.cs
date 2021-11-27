using System;

namespace lab5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Лабораторная работа №5 Задание 1 (＾• ω •＾)";
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Введите координату Х1");
            //var x1 = Console.ReadLine();
            var x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координату У1");
            var y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координату Х2");
            var x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координату У2");
            var y2 = Convert.ToDouble(Console.ReadLine());


            double l1 = Math.Pow((x1-y1),2);
            double l2 = Math.Pow((x2-y2),2);

            double l = Math.Sqrt(l1+l2);


            Console.WriteLine($"Расстояние между двумя точками равно {l}");

            Console.ReadKey();
        }
    }
}
