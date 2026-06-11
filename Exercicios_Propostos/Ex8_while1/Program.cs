using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8_while1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Contagem regressiva

            Console.WriteLine("Contagem regressiva");
            int n = 10;
            while (n > 0)
            {
                Console.WriteLine(n);
                n--;
            }
        }
    }
}
