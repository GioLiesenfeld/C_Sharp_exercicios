using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9_if3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ler dois números e mostrar se são iguais ou qual é o maior e menor

            Console.Write("Digite um valor inteiro: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite um valor inteiro: ");
            int n2 = int.Parse(Console.ReadLine());

            if (n1 == n2)
            {
                Console.WriteLine("Os números possuem o mesmo valor. ");
            }
            else if (n1 < n2)
            {
                Console.WriteLine($"O número {n2} é maior que {n1}.");
            }
            else {
                Console.WriteLine($"O número {n1} é maior que {n2}.");
            }


        }
    }
}
