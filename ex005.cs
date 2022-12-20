using System;
using System.Globalization;

namespace ex005
{
    internal class Program {
        static void Main(string[] args) {


            string[] var_1 = Console.ReadLine().Split(' ');
            int codPeca_1 = int.Parse(var_1[0]);
            int numPeca_1 = int.Parse(var_1[1]);
            double valorPeca_1 = double.Parse(var_1[2]);

            string[] var_2 = Console.ReadLine().Split(' ');
            int codPeca_2 = int.Parse(var_2[0]);
            int numPeca_2 = int.Parse(var_2[1]);
            double valorPeca_2 = double.Parse(var_2[2]);

            double pagar = (numPeca_1 * valorPeca_1) + (numPeca_2 * valorPeca_2);

            Console.WriteLine($"VALOR A PAGAR: R$ {pagar.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
