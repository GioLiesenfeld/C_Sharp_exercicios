using System.Globalization;
namespace Course
{
    class program
    {
        static void Main(string[] args)
        {

            string nome = "Giovana";
            char genero = 'F';
            int idade = 24;
            double saldo = 2550.768909879;


            //USO DE TOSTRING, SYSTEM GLOBALIZATION
            Console.WriteLine("Hello world");
            Console.WriteLine(nome);
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo.ToString("F2"));//usa-se ToString("F + o numero de casas decimais")
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));//desabilita qualquer especificidade de país
            //o código se torna padrão

            
            
            //PLACEHOLDERS, CONCATENAÇÃO E INTERPOLAÇÃO

            //placeholder
            Console.WriteLine("{0} tem {1} anos e {2} reais", nome, idade, saldo.ToString("F2"));

            //interpolação
            Console.WriteLine($"{nome} tem {idade} anos e {saldo} reais");

            //Concatenação
        }

    }
}
