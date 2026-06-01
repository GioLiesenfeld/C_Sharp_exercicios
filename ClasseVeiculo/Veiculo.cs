namespace ClasseVeiculo;

public abstract class Veiculo
{
    protected double TaxaDiaria { get; set; }

    public abstract double CalcularValorTotal(int numDiarias);
}
