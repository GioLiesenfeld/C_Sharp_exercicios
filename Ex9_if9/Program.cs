using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9_if9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Controle de Login");
            Console.Write("Digite o nome do usuário: ");
            string usuario = Console.ReadLine();
            Console.Write("Digite a senha: ");
            string senha = Console.ReadLine();

            if (usuario != "adm")
            {
                Console.WriteLine("Usuário inválido.");
            }
            else if (senha != "1234")
            {
                Console.WriteLine("Senha inválida!");
            }
            else
            {
                Console.WriteLine("Acesso permitido!");
            }
        }
    }
}
