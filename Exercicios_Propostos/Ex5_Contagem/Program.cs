using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_Contagem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número e eu contarei até chegar nele! ( : ");
            int num = int.Parse(Console.ReadLine());

            int contador = 0;
            while (contador <= num)
            {
                Console.WriteLine(contador);
                contador++;
            }
        }
    }
}
