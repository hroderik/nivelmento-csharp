using System;
using System.Globalization;

namespace ex004
{
    internal class Program {
        static void Main(string[] args) {

            int fun, hor;
            double val_Hor, sal;

            fun = int.Parse(Console.ReadLine());
            hor = int.Parse(Console.ReadLine());
            val_Hor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            sal = val_Hor * hor;

            Console.WriteLine($"NUMBER = {fun}");
            Console.WriteLine($"SALARY = U$ {sal.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
