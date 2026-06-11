using System;
using System.ComponentModel.Design;
using System.Runtime.Serialization;

namespace Course
{
    // Classe Pessoa (não tem Main aqui)
    class Pessoa
    {
        public string nome;
        public int idade;

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
        }
    }

    // Classe Program com Main (ponto de entrada do programa)
    class Program
    {
        static void Main(string[] args)  // <-- Main precisa estar aqui
        {
            Pessoa p1 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Digite seu nome: ");
            p1.nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            p1.idade = int.Parse(Console.ReadLine());
            Console.Write(".");

            Pessoa p2 = new Pessoa();
            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Digite seu nome: ");
            p2.nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            p2.idade = int.Parse(Console.ReadLine());

            
            
            p1.Apresentar();

            p2.Apresentar();

            if (p1.idade > p2.idade)
            {
                Console.WriteLine("A primeira pessoa é mais velha.");
            }
            else if (p2.idade > p1.idade)
            {
                Console.WriteLine("A segunda pessoa é mais velha.");
            }
            else
           {
                Console.WriteLine("Ambos possuem a mesma idade.");
            }
        }
    }
}