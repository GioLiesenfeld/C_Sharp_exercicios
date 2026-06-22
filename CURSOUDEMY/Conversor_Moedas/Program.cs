using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversor conversor = new Conversor();

            Console.WriteLine("CONVERSOR DE MOEDAS");
            Console.Write("Digite a cotação atual do dólar: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite quantos dólares serão comprados: ");
            double dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);  

            double total = Conversor.ValorTotal(cotacao, dolares);

            Console.WriteLine($"O valor total a ser pago em reais será: R${total:F2}");
        }
    }
}