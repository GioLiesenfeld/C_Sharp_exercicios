using System;
using Criacao_Classes.Classes;

namespace Criacao_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine($"Nome do produto: {produto.nome}!");
            Console.WriteLine($"Preço: {produto.preco.ToString("F2")}");
            Console.ReadLine();
        }
    }
}
