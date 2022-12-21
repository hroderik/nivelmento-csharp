using System;

namespace ex010
{
    internal class Program {
        static void Main(string[] args) {

            string[] valores = Console.ReadLine().Split(' ');
            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);
            int horas;

            if (a >= b) {
                horas = 24 - a + b;
            }
            else {
                horas = b - a;
            }
            
            Console.WriteLine($"O JOGO DUROU {horas} HORA(S)");
        }
    }
}
