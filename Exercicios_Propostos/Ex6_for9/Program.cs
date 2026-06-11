using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_for9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pedir 10 números ao usuário e dizer qual é o maior

            int maior = 0;
            for(int i = 1; i <= 10; i++)
            {
                Console.Write("Digite um número inteiro: ");
                int n = int.Parse(Console.ReadLine());
                if (n > maior){ 
                    
                    maior = n;
                }
            }


            Console.Write($"O maior número digitado foi: {maior}");
        }
      
    }
}
