using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_for6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Contar quantas vogais exitem em cada palavra

            Console.WriteLine("Contador de Vogais");
            Console.Write("Digite uma palavra: ");
            string palavra = Console.ReadLine();

            if (string.IsNullOrEmpty(palavra))
            {
                Console.WriteLine("Nenhuma palavra foi digitada! Digite algo na próxima vez.");
                return;
            }

            Console.WriteLine($"DEBUG → Palavra: '{palavra}', Length: {palavra.Length}");

            int qtdvogais = 0;
            
            for(int i = 0; i < palavra.Length; i++)
            {
                char letra = char.ToLower(palavra[i]);

                if (letra == 'a'|| letra == 'e'|| letra == 'i' || letra == 'o' || letra == 'u'){
                    
                    qtdvogais++;
                
            
                }

                
            }

            Console.Write($"A quantidade de vogais na palavra {palavra} é: {qtdvogais}.");

        }
                
    }
}
