
using System;

class Program
{
    static void Main()
    {
        decimal[,] numeros = 
        {
            { 1.9m, 1.7m },
            { 1.8m, 1.3m }
        };
        
        decimal soma = 0;
        int elementos = 0;
        
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(numeros[i, j] + " ");
                soma += numeros[i, j];
                elementos++;
            }
            Console.WriteLine();
        }
        
        decimal media = soma / elementos;
        Console.WriteLine("A média dos valores é: " + media.ToString("F2"));
        
        Console.ReadKey();
    }
}
