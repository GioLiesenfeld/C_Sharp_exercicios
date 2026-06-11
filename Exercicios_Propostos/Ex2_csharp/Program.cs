using System;
using System.ComponentModel.Design;

//Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X,
//um valor por linha, inclusive o
//X, se for o caso

Console.Write("Digite um valor inteiro entre 1 e 1000: ");
int valor = int.Parse(Console.ReadLine());


for (int i = 1; i <= valor; i++)
{
    if (i % 2 == 1)
    {
        Console.WriteLine(i);
    }

}
