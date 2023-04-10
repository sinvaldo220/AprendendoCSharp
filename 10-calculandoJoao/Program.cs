using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 3751.01;
        string desconto = "";

        //ifs aqui
        if(salario <= 1899.99)
        {
            _ = salario;
        }
        else if(salario >= 1900.00 && salario <= 2800.00)
        {
            desconto = "De 1900.0 até 2800.0, o IR é de 7.5% e pode deduzir na declaração o valor de R$ 142;"; salario = salario - 142;
        }
        else if(salario >= 2800.01 && salario <= 3751.00)
        {
            desconto = "De 2800.01 até 3751.0, o IR é de 15% e pode deduzir R$ 350;"; salario = salario - 350;
        }
        else
        {
            desconto = "De 3751.01 até 4664.00, o IR é de 22.5% e pode deduzir R$ 636."; salario = salario - 636;
        }
        Console.WriteLine(desconto + "Com estes descontos o salário de joão é de: " + salario);
        Console.ReadLine();
    }
}