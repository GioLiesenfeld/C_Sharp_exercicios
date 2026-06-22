using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace MediaAluno
{
    internal class Aluno
    {
        public string Nome;
        public double[] Notas = new double[3];

        public double SomaNotas()
        {

            return (Notas[0] + Notas[1] + Notas[2]);
        }
        public string Resultado()
        {
            return SomaNotas() < 60 ? "Reprovado" : "Aprovado";
        }
        public double PontosFaltantes()
        {
            if (SomaNotas() >= 60)
            {
                return 0; 
            }
            return 60 - SomaNotas();
        }
        public override string ToString()
        {
            return $"A nota final é: {SomaNotas().ToString("F2")}{Environment.NewLine}" +
                   $"{Resultado()}{Environment.NewLine}";
                   
        }









    }
   
}
