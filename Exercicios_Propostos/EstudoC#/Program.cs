using System;
using System.Globalization;

string produto1 = "Computador";
string produto2 = "Mesa de escritório";

byte idade = 32;
int codigo = 5290;
char genero = 'M';

double preco1 = 2100.0;
double preco2 = 650.50;
double medida = 53.234567;

Console.WriteLine("Produtos");
Console.WriteLine($"{produto1}, cujo preço é R${preco1}.");
Console.WriteLine($"{produto2}, cujo preço é R${preco2}");

Console.WriteLine($"Medida com 8 casas decimais: {medida.ToString("F8")}.");
Console.WriteLine($"Arredondado para 3 casas decimais: {medida.ToString("F3")}");
Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F4", CultureInfo.InvariantCulture)}");
