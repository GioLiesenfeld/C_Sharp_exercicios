using MediaAluno;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            {

                Console.WriteLine("MÉDIA DE ALUNOS");
                Console.Write("Nome: ");
                aluno.Nome = Console.ReadLine();

                double[] maximas = { 30, 35, 35 };

                for (int i = 0; i < 3; i++)
                {
                    double nota;

                    do
                    {
                        Console.Write($"Envie a {i + 1}º nota: ");
                        nota = double.Parse(Console.ReadLine());

                        if (nota < 0 || nota > maximas[i])
                        {
                            Console.WriteLine("Nota inválida!");

                        }

                    }
                    while (nota < 0 || nota > maximas[i]);

                    aluno.Notas[i] = nota;

                }

                Console.WriteLine(aluno);
                if (aluno.SomaNotas() < 60)
                {
                    Console.WriteLine($"FALTARAM {aluno.PontosFaltantes():F2} PONTOS");
                }
            }
        }
    }
}