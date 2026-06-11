using System.Security.Cryptography.X509Certificates;

namespace ClassePessoa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            Pessoa p1 = new Pessoa();

            p.Nome = "Giovana";
            p.Idade = 23;

            p.Apresentar();
            p.VerificarIdade();

            p1.Nome = "Leo";
            p1.Idade = 25;
            p1.Apresentar();
        }
    }
}
