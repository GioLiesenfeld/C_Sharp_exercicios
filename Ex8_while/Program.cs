using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Imprimindo uma contagem de 1 a 10 com while

            Console.WriteLine("Contagem com While");

            int n = 1; 
            while (n <= 10)
            {
                Console.WriteLine(n);
                n++;
            }
        }
    }
}
