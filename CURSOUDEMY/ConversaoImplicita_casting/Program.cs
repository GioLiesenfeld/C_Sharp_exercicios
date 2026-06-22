namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //CONVERSÃO IMPLÍCITA

            float x = 4.5f;//4 bytes
            double y = x;//8 bytes
            //o menor cabe dentro do MAIOR

            Console.WriteLine(y);

            //CASTING

            double a;
            float b;
            int c;

            a = 5.1;
            b = (float)a;//Liberação do conteúdo de 8 dentro de 4;
            Console.WriteLine(b);

            c = (int)a;
            Console.WriteLine(c);

            int d = 5;
            int e = 2;

            double resultado = (double)d / e;
            Console.WriteLine(resultado);

        }

    }
}