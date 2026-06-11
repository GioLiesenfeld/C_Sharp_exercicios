using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_for5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mostrar múltiplos de 5 ente 1 e 100.

            for (int i = 1; i <= 100; i++)
            {
                if(i%5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
