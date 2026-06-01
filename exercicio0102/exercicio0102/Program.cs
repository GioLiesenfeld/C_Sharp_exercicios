using System;
using System.Formats.Asn1;

class Program
{
    static void Main()
    {
        Console.WriteLine("Calculando a área do Círculo");
        Console.WriteLine("Informe o raio do círculo: ");
        string entrada = Console.ReadLine();
        double r = double.Parse(entrada);

        double area = 3.14159 * Math.Pow(2, r);
        Console.WriteLine($"A área do círculo é de {area:F4}");
    


    }
}
