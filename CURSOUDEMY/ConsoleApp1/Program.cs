namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //ENTRADA DE DADOS 

            string s = Console.ReadLine(); //comando readline permite entradas do usuário
            string[] vet = s.Split(' ');// comando split fatia a entrada com base nos espaços
            string a = vet[0];
            string b = vet[1];
            string c = vet[2];

            Console.WriteLine(s);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}