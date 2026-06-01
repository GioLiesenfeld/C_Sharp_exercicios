using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_comparacao_de_valores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor: ");
            int v1 = int.Parse(Console.ReadLine());
            Console.Write("Digite um valor: ");
            int v2 = int.Parse(Console.ReadLine());
            int maior = 0;
            if (v1 > v2)
            {
                maior = v1;
            }
            if (v2 > v1)
            {
                maior = v2;
            }
            else 
            {
                maior = v1;
                Console.WriteLine("Os valores são iguais. ");
            }

                Console.Write($"O maior valor digitado é {maior}.");

        }
               
            
            
            
    }
}
