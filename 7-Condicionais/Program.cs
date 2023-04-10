using System;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto - Condicionais");

            int idade = 17;
            int qtdPessoas = 2;

            if (idade >= 18)
            {
                Console.WriteLine("A sua idade é: " + idade + " Pode entrar");
            }
            else
            {
                if (qtdPessoas > 1)
                {
                    Console.WriteLine("Ele esta acompanhado pode entrar");
                }
                else
                {
                    Console.WriteLine("Não pode entrar pois a sua idade é: " + idade + " menor do que a idade exigida");
                }

            }



            Console.WriteLine("Tecle enter para fechar");
            Console.ReadLine();
        }
    }
}
