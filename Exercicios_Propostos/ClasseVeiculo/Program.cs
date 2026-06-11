namespace ClasseVeiculo;

internal class Program
{
    static void Main(string[] args)
    {
        Carro carro = new Carro(50);
        Moto moto = new Moto(25);

        double totalCarro = carro.CalcularValorTotal(10);
        double totalMoto = moto.CalcularValorTotal(10);
        Console.WriteLine($"O valor total para Carro fica R${totalCarro}");
        Console.WriteLine($"O valor total para Moto fica R${totalMoto}");
    }
}
