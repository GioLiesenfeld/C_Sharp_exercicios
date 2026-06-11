using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Classe03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MediaNotas aluno = new MediaNotas();

            Console.WriteLine("Digite o nome do aluno: ");
            aluno.nome = Console.ReadLine();

            Console.WriteLine("Insira a primeira nota: ");
            aluno.n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            aluno.n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            aluno.n3 = double.Parse(Console.ReadLine());


            aluno.ExibirMedia();

        }
    }
}
