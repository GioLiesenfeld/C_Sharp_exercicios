using System.Reflection.Metadata;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicita os dados do usuário necessários para a instanciação
            Console.Write("Entre o número da conta: ");
            string numeroConta = Console.ReadLine();
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Háverá depósito inicial (S/N)? ");
            string resposta = Console.ReadLine();

            
            //Invalida respostas fora do solicitado
            while(resposta.ToUpper() != "S" && resposta.ToUpper() != "N")
            {
                Console.Write("Resposta inválida. Tente outra vez (S/N): ");
                resposta = Console.ReadLine();
            }

            //Após obter resposta válida, instancia o primeiro objeto
            ContaBancaria cb1;


            //Permite o usuário optar entre depositar um valor inicial ou não, utilizando métodos consatrutores diferentes
            if (resposta.ToUpper() == "S")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                cb1 = new ContaBancaria(numeroConta, nome, depositoInicial);
                Console.WriteLine();
                Console.WriteLine("Dados da Conta");
                Console.WriteLine(cb1);
            }
            else
            {
                cb1 = new ContaBancaria(numeroConta, nome);
                Console.WriteLine();
                Console.WriteLine("Dados da Conta");
                Console.WriteLine(cb1);

            }
            
            //Entrega a opção de depositar um valor com o método Depositar()
            Console.Write("Entre com um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine());
            cb1.Depositar(deposito);
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados");
            Console.WriteLine(cb1);
            Console.WriteLine();

            //Entrega a opção de sacar um valor com o método Sacar()
            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine());
            cb1.Sacar(saque);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados:");
            Console.WriteLine(cb1);
        }
    }
}