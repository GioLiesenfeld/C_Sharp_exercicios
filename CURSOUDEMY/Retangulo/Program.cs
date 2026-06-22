namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();

            Console.WriteLine("MEDIDAS DO RETÂNGULO");
            
            Console.Write("Largura do Retângulo: ");
            ret.Largura = double.Parse(Console.ReadLine());
            
            Console.Write("Altura do Retângulo: ");
            ret.Altura = double.Parse(Console.ReadLine());

            double area = ret.CalcularArea();
            Console.WriteLine($"A área do retângulo é: {area}");

            double perimetro = ret.CalcularPerimetro();
            Console.WriteLine($"O perímetro do retângulo é: {perimetro}");
            
            double diagonal = ret.CalcularDiagonal();
            Console.WriteLine($"A diagonal é: {diagonal}");



        }
    }
}