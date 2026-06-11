using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex9_if10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo de IMC");
            Console.Write("Digite sua altura em metros: ");
            double alt = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite seu peso em kg: ");
            double kg = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imc = (kg / (alt * alt));

            if (imc < 18.5)
            {
                Console.WriteLine("Magreza extrema.");
            }
            else if (imc >= 18.5 && imc < 25) 
            {
                Console.WriteLine("Peso normal");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("Sobrepeso");
            }
            else if(imc >= 30 && imc < 35)
            {
                Console.WriteLine("Obesidade grau I");
            }
            else if(imc >=35 && imc < 40)
            {
                Console.WriteLine("Obesidade grau II");
            }
            else
            {
                Console.Write("Obesidade grau III");
            }

            Console.WriteLine($"O seu imc resulta em {imc:F2}");
            
        }
    }
}
