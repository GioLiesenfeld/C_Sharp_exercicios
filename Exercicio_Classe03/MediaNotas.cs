using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Classe03
{
    internal class MediaNotas
    {
        public string nome {  get; set; }
        public double n1 { get; set; }
        public double n2 { get; set; }
        public double n3 { get; set; }

        public double CalcularMedia()
        {
            return ((n1 + n2 + n3) / 3);
            
        }
        public void Aprovacao(double resultado)
        {
        
            if (resultado >= 6)
            {
                Console.WriteLine("Resultado: APROVADO!");
            }
            else if (resultado < 6)
            {

                Console.WriteLine("Resultado: REPROVADO!");

            }
        }

        public void ExibirMedia()
        {
            double media = CalcularMedia();
            Console.WriteLine($"Aluno: {nome}");
            Console.WriteLine($"A Média de {nome} é {media}.");
            Aprovacao (media);
            
        }


    }
}
