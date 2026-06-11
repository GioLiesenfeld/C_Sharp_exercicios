using Classes_ex2;

class Program
{

    static void Main(string[] args)

    {

        NomeSalario p = new NomeSalario();

        Console.Write("Digite o seu nome: ");
        p.Nome = Console.ReadLine();
    
        Console.Write("Digite seu salário: ");
        p.Salario = double.Parse(Console.ReadLine());


        p.Exibir();
    
    
    
    }
}