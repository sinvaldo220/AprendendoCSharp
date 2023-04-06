using System;
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine( "Executando o projeto 5 - caracters e textos");

        char letra = 'a'; //tipo char usa apenas um caracter
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        letra = (char)(86 + 1);
        Console.WriteLine(letra);

        string primeiraFrase = "Cursos de Tecnologia ";
        Console.WriteLine(primeiraFrase + 2022);

        string vazia = "";
        Console.WriteLine(vazia);

        letra = ' '; //tipo char ele não pode ficar vazio, tem que ter pelo menos um espaço

        string cursos = @"Cursos disponiveis:
        - Go
        - C#
        - Python  
        - Java";// "@" deixa um abaixo do outro.
        Console.WriteLine(cursos);



        Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();
    }
}
