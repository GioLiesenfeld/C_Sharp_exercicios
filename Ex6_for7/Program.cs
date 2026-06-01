using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_for7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pedir todos os múltiplos de 5 entre 1 e 100

            Console.WriteLine("Multiplos de 5 entrte 1 e 100: ");

            for(int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0){

                    Console.WriteLine(i);

                }
            }

        }
    }
}
