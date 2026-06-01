using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ler um inteiro e indicar se é positivo, negativo ou 0.

            Console.Write("Indique um número inteiro: ");
            int n = int.Parse(Console.ReadLine());

            if (n > 0)
            {
                Console.WriteLine("O número indicado é positivo!");
            }
            else if (n < 0)
            {
                Console.Write("O número indicado é negativo.");
            }
            else
            {
                Console.Write("O número indicado é 0. ");
            }
        }
    }
}
