using System;

namespace pr7
{
    /// <summary>
    /// Главный класс приложения.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Точка входа в приложение: вычисляет 5-е число Фибоначчи и выводит результат в консоль.
        /// </summary>
        /// <param name="args">Аргументы командной строки, переданные при запуске.</param>
        static void Main(string[] args)
        {
            int result = Fibonacci(5);
            Console.WriteLine(result);
        }
        /// <summary>
        /// Вычисляет n-е число последовательности Фибоначчи итеративным методом.
        /// </summary>
        /// <param name="n">Порядковый номер числа в последовательности Фибоначчи начиная с 0.</param>
        /// <returns>Целочисленное значение n-го числа Фибоначчи.</returns>
        static int Fibonacci(int n)
        {
            Console.WriteLine("The output is: ");
            int n1 = 0;
            int n2 = 1;
            int sum;

            for (int i = 2; i <= n; i++)
            {
                sum = n1 + n2;
                n1 = n2;
                n2 = sum;
            }

            return n == 0 ? n1 : n2;
        }
    }
}

