using System;
using System.Globalization;

namespace ex002
{
    internal class Program {
        static void Main(string[] args) {

            double area, raio, pi = Math.PI;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = pi * Math.Pow(raio, 2);

            Console.WriteLine($"A={area.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}
