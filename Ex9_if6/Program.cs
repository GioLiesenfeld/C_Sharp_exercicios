using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9_if6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Limite de Crédito");
            Console.Write("Informe seu salário: ");
            decimal sal = decimal.Parse(Console.ReadLine());
            Console.Write("Informe o valor da parcela a pagar: ");
            decimal parc = decimal.Parse(Console.ReadLine());

            decimal limite30 = sal * 0.30m;
            decimal limite20 = sal * 0.20m;

            if (parc > limite30)
            {
                Console.WriteLine("Saldo negado!");
            }
            else if (parc > limite20)
            {
                Console.Write("Saldo aprovado com risco.");
            }
            else
            {
                Console.WriteLine("Saldo aprovado!");
            }
        }
    }
}
