using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Ex9_if4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ler uma nota e apresentar um conceito

            Console.Write("Digite a sua nota: ");
            float nota = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if ( nota > 10 || nota < 0)
            {
                Console.WriteLine("Nota inválida!");
            }
            else if (nota >= 9)
            {
                Console.WriteLine("O conceito é A!");
            }
            else if (nota >= 7)
            {
                Console.WriteLine("O conceito é B!");
            }
            else if (nota >= 5)
            {
                Console.WriteLine("O conceito é C!");
            }
            else if (nota >= 0)
            {
                Console.WriteLine("O conceito é D!");
            }
            
        
        
        
        
        
        
        }
    }
}
