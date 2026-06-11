using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8_while7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //contador de positivos. Se o usuário digitar 0 o programa para e mostra a soma.

            Console.WriteLine("Contador de Positivos");
            Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            int soma = 0;

            while (num != 0)
            {
               
                if (num > 0)
                {
                    soma += num;
                }

                Console.Write("Digite um número: ");
                num = int.Parse(Console.ReadLine());


            }



            Console.Write($"A soma dos números positivos é {soma}");

        }
           


}    }