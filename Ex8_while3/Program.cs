using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8_while3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*soma de números enquanto o usuário digitar
             * 0 vale para parar e no final mostra a soma */
            
            int soma = 0;

            Console.Write("Digite um número: ");
            int n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                soma = soma + n;
                Console.Write("Digite um número: ");
                n = int.Parse(Console.ReadLine());
            }

            Console.Write($"A soma de todos os números é: {soma}.");
        
        }
    }//CONTINUAR EX 5 VALIDAÇÃO DE SENHA
}
