using System;
using System.Globalization;

namespace ex005
{
    internal class Program {
        static void Main(string[] args) {

            string[] var = Console.ReadLine().Split(' ');
            int codPeca_1 = int.Parse(var[0]);
            int numPeca_1 = int.Parse(var[1]);
            double valorPeca_1 = double.Parse(var[2], CultureInfo.InvariantCulture);

            var = Console.ReadLine().Split(' ');
            int codPeca_2 = int.Parse(var[0]);
            int numPeca_2 = int.Parse(var[1]);
            double valorPeca_2 = double.Parse(var[2], CultureInfo.InvariantCulture);

            double pagar = (numPeca_1 * valorPeca_1) + (numPeca_2 * valorPeca_2);

            Console.WriteLine($"VALOR A PAGAR: R$ {pagar.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
