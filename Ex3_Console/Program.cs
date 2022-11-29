using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Интервал [a, b] на котором будет вычисляться функция
            double a = 0, b = 0;

            // Шаг функции
            double h = 0;

            while (true)
            {
                try
                {
                    Console.Write("Введите начальное значение интервала: ");
                    a = double.Parse(Console.ReadLine());

                    Console.Write("Введите конечное значение значение интервала: ");
                    b = double.Parse(Console.ReadLine());

                    Console.Write("Введите шаг функции: ");
                    h = double.Parse(Console.ReadLine());

                    if (h == 0) throw new Exception("Выберите шаг отличный от нуля! Количество итераций будет бесконечно!");
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

            Console.WriteLine("\n\n");

            // Возрастающая функция
            if (a <= b)
            {
                Console.WriteLine($"Результат вычисления функции с интервалом [{a}, {b}]\n(результат функции округлен до двух знаков после запятой)");
                Console.WriteLine("\tx\ty");
                for (double i = a; i <= b; i += h)
                {
                    double y = 0;
                    f(i, out y);
                    Console.WriteLine($"\t{i}\t{Math.Round(y, 2)}");
                }
            }
            else if (a > b)
            {
                Console.WriteLine($"Результат вычисления функции с интервалом [{a}, {b}]\n(результат функции округлен до двух знаков после запятой)");
                Console.WriteLine("\tx\ty");
                for (double i = a; i >= b; i -= h)
                {
                    double y = 0;
                    f(i, out y);
                    Console.WriteLine($"\t{i}\t{Math.Round(y, 2)}");
                }
            }
        }
        static double f(double x)
        {
            double result = 0;

            if (Math.Abs(x) < Math.PI / 2) result = Math.Sin(x);
            else if (Math.Abs(x) >= Math.PI / 2 && Math.Abs(x) <= Math.PI) result = Math.Cos(x);
            else if (Math.Abs(x) > Math.PI) result = 0;

            return result;
        }

        // Перегруженный метод вычисления функции
        static void f(double x, out double y)
        {
            double result = 0;

            if (Math.Abs(x) < Math.PI / 2) result = Math.Sin(x);
            else if (Math.Abs(x) >= Math.PI / 2 && Math.Abs(x) <= Math.PI) result = Math.Cos(x);
            else if (Math.Abs(x) > Math.PI) result = 0;

            y = result;
        }
    }
}
