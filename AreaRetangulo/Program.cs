using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo do Retângulo");
            Console.WriteLine("--------------------");

            CalculoRetangulo retangulo = new CalculoRetangulo();

            Console.WriteLine("Digite a altura do retângulo: ");
            retangulo.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a largura do retângulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine());

            retangulo.Resultados();
        }
    }
}
