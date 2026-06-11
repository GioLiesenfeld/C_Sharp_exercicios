using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassePessoa
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public int Idade {  get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"O nome é {Nome} e a idade é {Idade}.");
        }
        public void VerificarIdade()
        {
            if (Idade < 0)
            {
                Console.WriteLine("Idade inválida!");
            }
            if (Idade >= 18)
            {
                Console.WriteLine("Pessoa maior de idade.");
            }
            else
            {
                Console.WriteLine("Pessoa menor de idade.");
            }

            
        }

    }
}
