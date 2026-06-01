using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //maior ou menor de idade
            //add: adicional de quantos anos faltam para a maioridade

            Console.Write("Informe a sua idade: ");
            int idade = int.Parse(Console.ReadLine());


            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade!");

            }
            else if (idade < 18)
            {
                int cont = 18 - idade;
                Console.WriteLine($"Você é menor de idade e faltam {cont} anos para atingir.");
            }
            else
            {
                Console.WriteLine("Erro ao idicar idade. Tente novamente!"); 
            }
        
        
        
        }

    }
}
