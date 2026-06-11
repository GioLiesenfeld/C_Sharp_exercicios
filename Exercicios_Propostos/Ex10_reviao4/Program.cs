using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_reviao4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite: ");
            Console.WriteLine("1 - Para mostrar os números de 1 a 10. ");
            Console.WriteLine("2 - Para mostrar os pares de 1 a 20.");
            Console.WriteLine("3 - Para sair. ");
            int resp = int.Parse(Console.ReadLine());

            while (resp != 3)
            {

                if (resp == 1)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine(i);
                    }

                }
                else if (resp == 2)
                {
                    for (int i = 1; i <= 20; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            
                Console.WriteLine("Digite: ");
                Console.WriteLine("1 - Para mostrar os números de 1 a 10. ");
                Console.WriteLine("2 - Para mostrar os pares de 1 a 20.");
                Console.WriteLine("3 - Para sair. ");
                resp = int.Parse(Console.ReadLine());


            }        
        }   
            
        
            
    }
}
