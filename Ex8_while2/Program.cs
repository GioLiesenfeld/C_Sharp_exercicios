using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8_while2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //imprimir todos os números pares de 1 a 20

            int n = 1;
            while (n <= 20)
            {
                Console.WriteLine(n);
                n = n + 2;
            }
        }
    }
}
