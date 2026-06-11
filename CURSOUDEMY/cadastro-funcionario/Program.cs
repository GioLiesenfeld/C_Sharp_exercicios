using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastro_funcionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Funcionario f1 = new Funcionario();
           Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.Salario = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.Salario = decimal.Parse(Console.ReadLine());

            decimal mediaSal = (f1.Salario + f2.Salario) / 2;

            Console.WriteLine();
            Console.WriteLine("TESTE");

            Console.WriteLine($"A média de salário é R$ {mediaSal:F2}");

            Console.ReadKey();

        }
    }
}
