using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex6_for4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //uso do for para receber dados 
           
            float soma = 0;
            for(int i = 1; i <= 5; i++)
            {
                Console.Write("Escreva um número: ");
                float num = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                soma = soma + num;
            }

            float media = (soma / 5);
            Console.Write($"A média dos valores informados é: {media}.");
        
        
        
        }
    }
}
