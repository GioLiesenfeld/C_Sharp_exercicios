using System;
using System.Globalization;

string produto1 = "computador";
string produto2 = "Mesa de escritório";

byte idade = 30;
int codigo = 5290;
char genero = 'M';

double preco1 = 2100.0;
double preco2 = 650.50;
double medida = 53.234567;

Console.WriteLine("Produtos:");
Console.Write($"{produto1}, cujo preço é $R{preco1}.");
Console.WriteLine($"{produto2}, cujo preço é $R{preco2}.");

Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero:{genero}.");

Console.Write($"Medida com oito casas decimais:{medida}");
Console.Write($"Arredondado (três casas decimais):{medida.ToString("F3")}. ");
Console.WriteLine();


