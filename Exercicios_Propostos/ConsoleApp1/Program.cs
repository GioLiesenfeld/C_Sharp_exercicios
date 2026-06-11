using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {


        static void Main(string[] args)
        {
            //reconhecimento de senha


            Console.Write("Digite a sua senha: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 1234)
            {
                Console.Write("Senha incorreta! Tente outra vez: ");
                senha = int.Parse(Console.ReadLine());
            }

            Console.Write("Senha correta!");
        }





    }
}
  


    
        