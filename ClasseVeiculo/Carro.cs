namespace ClasseVeiculo;

internal class Carro : Veiculo
{
    public Carro(double taxa)
    {
        TaxaDiaria = taxa;
    }
    public override double CalcularValorTotal(int numDiarias)
    {
        return TaxaDiaria * numDiarias;
    }
}
