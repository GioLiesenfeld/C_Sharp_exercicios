using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_for8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //imprimir o número de vogais digitadas pelo usuário

            Console.Write("Digite uma palavra e eu contarei as vogais: ");
            string palavra = Console.ReadLine();

            int qtdvogais = 0;
            for (int i = 0; i < palavra.Length; i++)
            {
                char letra = char.ToLower(palavra[i]);

                if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
                {   
                    qtdvogais++;
                 
                }
            }

            Console.Write($"A quantidade de vogais da palavra digitada é: {qtdvogais}");
        }
    }
}
