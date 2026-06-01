using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex9_if7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Avaliação de desempenho");
            Console.Write("Digite a sua média: ");
            double media = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Indique seu número de faltas: ");
            int faltas = int.Parse(Console.ReadLine());

            if (faltas < 0 || media < 0)
            {
                Console.WriteLine("Informações inválidas! Tente outra vez.");
            }
            else if (faltas > 25 && media < 6)
            {
                Console.Write("Você reprovou pelo número de faltas e pela média.");
            }
            else if (faltas > 25)
            {
                Console.WriteLine("Reprovado por faltas! Média dentro do esperado. ");
            }
            else if (media < 6)
            {
                Console.Write("Reprovado pela média! Presença dentro do esperado. ");
            }
            else
            {
                Console.WriteLine("Aprovado!");
            }
        }
    }
}
