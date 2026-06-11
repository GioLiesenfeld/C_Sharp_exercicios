using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8_while6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //média de notas...calcula a média quando digitar -1
           
            Console.WriteLine("Média de Notas");
            Console.Write("Digite sua nota: ");
            float nota = float.Parse(Console.ReadLine());
            int numnotas = 0;
            float soma = 0;
            

            while (nota != -1)
            {
                soma = soma + nota;
                numnotas++;
                Console.Write("Digite sua nota: ");
                nota = float.Parse(Console.ReadLine());
                
            
            }
            float media = (soma / numnotas);
            Console.WriteLine($"A média das notas enviadas é de {media}.");
        
        }
    }
}
