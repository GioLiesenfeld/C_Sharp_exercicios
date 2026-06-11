using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_revisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verificação de número: ");
            Console.WriteLine("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("O número digitado é negativo.");
            }
            else if (num > 0)
            {
                Console.WriteLine("O número digitado é positivo");
            }
            else
            {
                Console.WriteLine("O número digitado foi 0.");
            }

        }
    }
}
