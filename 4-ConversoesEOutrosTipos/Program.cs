using System;
class Program
{
    static void Main(string[] args)
    {
        double salario = 3000.15;
        Console.WriteLine(salario);

        int salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro);

        //long é um tipo de variavel de 64 bits
        long x = 2000000000000000000;
        Console.WriteLine(x);


        //short maximo
        short y = 32767;
        Console.WriteLine(y);

        //float e seu campo
        float altura = 1.62f;
        Console.WriteLine(altura);

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}
