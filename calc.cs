
using System;

public class Calc
{
public static void Main()
{
    Console.WriteLine("Multiplication Table:");
    Console.WriteLine("     1  2  3  4  5  6  7  8  9");
    for (int i = 1; i < 10; i++)
    {
        Console.Write($" {i} ");
        for (int j = 1; j < 10; j++)
        {
            string product = (i * j).ToString();
            Console.Write(product.PadLeft(3));
        }
        Console.WriteLine();
    }
}
}