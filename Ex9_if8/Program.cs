using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Ex9_if8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo de Tarifa de Energia");
            Console.Write("Digite o consumo em kWh: ");
            decimal consumo = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            decimal valortot = 0;

            if (consumo < 0)
            {
                Console.Write("Informação inválida...");
            }
            else if (consumo <= 100)
            {
                valortot = (consumo * 0.50m);
                Console.WriteLine("Faixa de consumo: Até 100 kWh. ");
                Console.WriteLine("Tarifa aplicada: R$ 0,50 por kWh. ");
                Console.Write($"Valor total do consumo: R${valortot}");
            }
            else if (consumo <= 300)
            {
                valortot = (consumo * 0.75m);
                Console.WriteLine("Faixa de consumo: entre 100 e 300 kWh. ");
                Console.WriteLine("Tarifa aplicada: R$ 0,75 por kWh. ");
                Console.Write($"Valor total do consumo: R${valortot}");
            }
            else
            {
                valortot = (consumo * 1m);
                Console.WriteLine("Faixa de consumo: acima de 300 kWh. ");
                Console.WriteLine("Tarifa aplicada: R$ 1,00 por kWh. ");
                Console.Write($"Valor total do consumo: R${valortot:F2}");

            }


        }

    }
}
