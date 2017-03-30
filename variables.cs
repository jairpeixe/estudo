using System;

namespace Variables
{
    class Programa
    {
        static void Main(string[] args)
        {
            /*int x;
            int y;

            x = 7;
            y = x + 3;

            Console.WriteLine(y);
            Console.ReadLine();*/

            Console.WriteLine("Qual o seu nome? ");
            Console.Write("Digite seu primeiro nome: ");
            string meuPrimeiroNome;
            meuPrimeiroNome = Console.ReadLine();

            string meuUtlimoNome;
            Console.Write("Digite seu utltimo nome: ");
            meuUtlimoNome = Console.ReadLine();

            Console.WriteLine("Oi, " + meuPrimeiroNome + " " + meuUtlimoNome);
        }
    }
}