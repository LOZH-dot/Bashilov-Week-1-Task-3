using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Числа для ввода
            double x = 0;
            double y = 0;
            double z = 0;
            double v = 0;

            while (true)
            {
                try
                {
                    Console.Write("Введите x: ");
                    x = double.Parse(Console.ReadLine());

                    Console.Write("Введите y: ");
                    y = double.Parse(Console.ReadLine());

                    Console.Write("Введите z: ");
                    z = double.Parse(Console.ReadLine());

                    Console.Write("Введите v: ");
                    v = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Ошибка: ");
                    Console.ResetColor();
                    Console.WriteLine(ex.Message);
                }

            }

            Console.Write($"\nМинимальным числом из ({x}, {y}, {z}, {v}) является число: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Min(Min(x, y), Min(z, v)));
            Console.ResetColor();

        }

        static double Min(double a, double b)
            => (a < b) ? a : b;
    }
}
