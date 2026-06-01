using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_ex2
{
    internal class NomeSalario
    {
        public string Nome {  get; set; }
        public double Salario { get; set; }

        public void Exibir()
        {
            Console.WriteLine($"O nome do funcionário: {Nome}");
            Console.WriteLine($"O salário: ${Salario}");
        }

    }
}
