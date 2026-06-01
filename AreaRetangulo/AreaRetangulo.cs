using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaRetangulo
{
    internal class CalculoRetangulo
    {
        public double Largura { get; set; }
        public double Altura { get; set; }


        public double CalcularArea()
        {
            return (Largura * Altura);
        }

        public double CalcularPerimetro()
        {
            return ((Altura * 2) + (Largura * 2));
        }

        public double CalcularDiagonal()
        {
            return Math.Sqrt((Math.Pow((double)Largura, 2) + (Math.Pow((double)Altura, 2))));
        }

        public void Resultados()
        {
            double diag = CalcularDiagonal();
            Console.WriteLine($"A área do retângulo é: {CalcularArea()}");
            Console.WriteLine($"O perímetro do retângulo é: {CalcularPerimetro()}");
            Console.WriteLine($"A diagonal do retângulo é: {diag.ToString}");

        }
    }

}
