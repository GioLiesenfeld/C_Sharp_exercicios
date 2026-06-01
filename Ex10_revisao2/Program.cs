using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_revisao2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Use while para contar de 0 até esse número.

            Use if para mostrar apenas os números pares
            */

            Console.Write("Me diga um número inteiro e positivo.");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
              
            }
            

        }
    }
}
