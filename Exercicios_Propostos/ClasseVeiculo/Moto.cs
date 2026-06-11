namespace ClasseVeiculo;

internal class Moto : Veiculo
{
    public Moto(double taxa)
    {
        TaxaDiaria = taxa;
    }
    public override double CalcularValorTotal(int numDiarias)
    {
        return TaxaDiaria * numDiarias;
    }    
}

