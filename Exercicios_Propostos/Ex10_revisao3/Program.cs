using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_revisao3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            for (int i = 1; i <=5; i++)
            {
                Console.Write("Informe um valor: ");
                int num = int.Parse(Console.ReadLine());
                if (num > 10)
                {
                    soma = soma + num;
                }

                
            }
            Console.Write(soma);
        }
    }
}
