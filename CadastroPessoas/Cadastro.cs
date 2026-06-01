
namespace CadastroPessoas
{
    internal class Cadastro //Public class NomeDaClasse
    {
        public string Nome { get; set; }//atributos
        public int Idade { get; set; }

        //Construtor
        public Cadastro(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        public void Apresentar()
        {
            Console.WriteLine($"Olá! Meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}


     
