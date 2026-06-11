using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8_while5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Construir uma tabuada com o número que o usuário enviar

            Console.WriteLine("Tabuada");
            Console.Write("Envie um número para eu multiplicar: ");
            int num = int.Parse(Console.ReadLine());

            int m = 1;
            while(m <=10)
            {
                Console.WriteLine($"{m} X {num} = {m * num}");
                m++;
            }
        }
    }
}
