using System;

namespace P12_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("executando o projeto 12 - calcula poupança 2");

            double investimento = 1000;

            for(int mes = 1; mes <= 12; mes++)
            {
                investimento = investimento + investimento * 0.005;
                Console.WriteLine(investimento);
                //mes++;
                //mes += 1;
            }
            Console.WriteLine("Tewcle para fechar...");
            Console.ReadLine();
        }
    }
}
