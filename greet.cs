using System;

namespace Frases
{
    public class Greets
    {
        public static void Main(string[] args)
        {
            string saud1 = "Olá " + " " + args[0];
            string saud2 = " Você está por aqui?";
            string saud3 = saud1 + "," + saud2;

            System.Console.WriteLine($"{saud3}");
        }
    }
}