using System;

namespace P11_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("executando o projeto 11 - calcula poupança");

            double investimento = 1000;
            // redimento de 0.5% (0.005) ao mês
            // mes 1
            //investimento = investimento + investimento * 0.005;
            // mes 2
            //investimento = investimento + investimento * 0.005;
            // mes 3
            //investimento = investimento + investimento * 0.005;

            int mes = 1;
            while(mes <= 12)
            {
                investimento = investimento + investimento * 0.005;
                Console.WriteLine(investimento);
                mes = mes + 1;
                //mes++;
                //mes += 1;
            }
            //Console.WriteLine( "investimento" + investimento);
            Console.WriteLine("Tewcle para fechar...");
            Console.ReadLine();
        }
    }
}
