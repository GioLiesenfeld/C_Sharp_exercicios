using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados_Funcionario
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;


        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public double AumentarSalario(double porcentagem)
        {
            return SalarioBruto =  (((porcentagem * SalarioBruto)) / 100) + SalarioBruto; 
        }
        public override string ToString()
        {
            return $"Funcionário: {Nome} | Salário: {SalarioLiquido()}";
        }
        


    }
        
}
