using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_for10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //imprimir os 10 primeiros números da sequência de fibonacci

            Console.WriteLine("Sequência de Fibonacci");

            int a = 0;
            int b = 1;

            for (int i =1; i <= 10; i++)
            {
                int n = a + b;
                Console.WriteLine(n);
                a = b;
                b = n;
            }
          
            

        }
    }
}
