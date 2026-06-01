using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite um segundo número: ");
            int num2 = int.Parse(Console.ReadLine());
            int soma = (num1 + num2);
            Console.WriteLine($"A soma entre {num1} e {num2} é {soma}.");
        }
    }
}
