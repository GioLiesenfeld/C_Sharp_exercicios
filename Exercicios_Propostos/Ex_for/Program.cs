using System;
using System.ComponentModel.Design;

Console.Write("Digite um valor inteiro: ");
int valor = int.Parse(Console.ReadLine());

int dentro = 0;
int fora = 0;

for (int i = 1; i <= valor; i++)
{
    Console.Write($"Digite o {i}º valor: ");
    int val = int.Parse(Console.ReadLine());
    
    if (val >= 10 && val <= 20) {
        dentro += 1; 
    }
    
    else {
        fora += 1;
    
    }    
}
Console.WriteLine($"Os valores entre (10, 20): {dentro}");
Console.Write($"Os valores fora: {fora}");



