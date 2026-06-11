using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_for3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Soma dos números 1 a 100 usando for
            int soma = 0;
            for (int i = 1; i <= 100; i++)
            {
                soma += i;
            }
            Console.WriteLine(soma);
        } 
    }
}
