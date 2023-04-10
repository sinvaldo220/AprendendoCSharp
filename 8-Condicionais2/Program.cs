using System;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 8 - Condicionais");

            int idade = 11;
            int qtdPessoas = 2;

            bool acompanhado = qtdPessoas > 1;
            bool grupo = true;

            if (idade >= 18 || acompanhado)
            {
                Console.WriteLine("A sua idade é: " + idade + " Pode entrar");
            }
            else
            {
                Console.WriteLine("Não pode entrar pois a sua idade é: " + idade + " menor do que a idade exigida");

            }

            Console.WriteLine("Tecle enter para fechar");
            Console.ReadLine();
        }
    }
}
