using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8_while9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // se o número for ímpar, o programa continua. Par, o programa encerra.

            Console.WriteLine("Verificação de número ímpar");
            Console.Write("Digite um número: ");
            int n = int.Parse(Console.ReadLine());

            while(n%2 != 0)
            {
                Console.Write("Digite outro número: ");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Você digitou um número par!");
        
        }
    }
}
