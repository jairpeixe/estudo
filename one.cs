using System;

namespace One
{
    public class Programa
    {
        public static void Main(string[] args)
        {
            string greet = args[0];
            var nome = "Jair da Silva Peixe Filho";
            System.Console.WriteLine($"Olá {nome} {greet}");
            var frase = "Teste de string no c#";
            System.Console.WriteLine($"String original {frase}");
            System.Console.WriteLine($"String minúscula {frase.ToLower()}");
            System.Console.WriteLine($"String maiúscula {frase.ToUpper()}");
        }
    }
}