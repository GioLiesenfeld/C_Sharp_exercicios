using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;


        public double CalcularArea()
        {
            return Largura * Altura;
        }
        public double CalcularPerimetro()
        {
            return (Largura * 2) + (Altura * 2);
        }
        public double CalcularDiagonal()
        {
            return Math.Sqrt(Math.Pow(Altura, 2) +(Math.Pow(Largura, 2)));
        }





    }
}
   
   
