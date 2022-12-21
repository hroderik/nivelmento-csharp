using System;
using System.Globalization;

namespace ex011
{
    internal class Program {
        static void Main(string[] args) {

            string[] valores = Console.ReadLine().Split(' ');
            int codigo = int.Parse(valores[0]);
            int quantidade = int.Parse(valores[1]);


            if (codigo == 1) {
                double total = 4.00 * quantidade;
                Console.WriteLine($"Total: R${total.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (codigo == 2) {
                double total = 4.50 * quantidade;
                Console.WriteLine($"Total: R${total.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (codigo == 3) {
                double total = 5.00 * quantidade;
                Console.WriteLine($"Total: R${total.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (codigo == 4) {
                double total = 2.00 * quantidade;
                Console.WriteLine($"Total: R${total.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (codigo == 5) {
                double total = 1.50 * quantidade;
                Console.WriteLine($"Total: R${total.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
