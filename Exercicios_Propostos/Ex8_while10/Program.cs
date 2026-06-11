using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8_while10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Peça um número ao usuário e mostre a sequência de fibonacci sem ultrapassar o valor

            Console.Write("Sequência de Fibonacci");
            Console.Write("Digite um número e eu mostrarei o valor mais próximo: ");
            int n = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;

            while (a <= n) {

                Console.WriteLine(a);
                int fib = a + b;
                a = b;
                b = fib; //não consegui
                
            }

        }
    }
}
