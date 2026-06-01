using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Calculadora");

        Console.WriteLine("Digite um número para somar: ");
        string entrada = Console.ReadLine();
        int num = int.Parse(entrada);

        Console.WriteLine("Digite um segundo número: ");
        string entrada2 = Console.ReadLine();
        int num2 = int.Parse(entrada2);

        int soma = num2 + num;

        Console.WriteLine($"A soma de {num} mais {num2} é {soma}.");
    }

}
  