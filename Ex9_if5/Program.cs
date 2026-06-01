using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9_if5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verificar três medidas e analisar se podem formar um triângulo

            Console.WriteLine("Formação de Triângulos");
            Console.Write("Indique o lado 1: ");
            float l1 = float.Parse(Console.ReadLine());
            Console.Write("Indique o lado 2: ");
            float l2 = float.Parse(Console.ReadLine());
            Console.Write("Indique o lado 3: ");
            float l3 = float.Parse(Console.ReadLine());

            if ( (l1 + l2) <= l3 || (l2 + l3) <= l1 || (l3 + l1) <= l2 )
            {
                Console.WriteLine("As medidas não formam um triângulo.");
            }
            else if ( l1 == l2 && l2 == l3)
            {
                Console.WriteLine("Você tem um triângulo equilátero!");
            }
            else if ( l1 == l2 || l2 == l3 || l3 == l1)
            {
                Console.WriteLine("Você tem um triângulo isósceles.");
            }
            else 
            {
                Console.WriteLine("Você tem um triângulo escaleno.");
            }
        }
    }
}
