using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_for1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //imprimir números pares de 2 a 20.
            Console.WriteLine("Imprimindo números PARES: ");
           
            for (int i = 1; i <= 20; i++)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
