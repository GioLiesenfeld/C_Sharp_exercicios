using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número para calcular a tabuada: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} X {num} =  {i * num}");
            }

        }
    }
}
