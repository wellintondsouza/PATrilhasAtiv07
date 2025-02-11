using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int rows = 4, cols = 2;
        int[,] numeros = new int[rows, cols];
        
        int soma = 0;
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                numeros[i, j] = random.Next(1, 11); // Gera números aleatórios entre 1 e 10
                Console.Write(numeros[i, j] + " ");
                soma += numeros[i, j];
            }
            Console.WriteLine();
        }
        
        Console.WriteLine("A soma dos números é: " + soma);
        Console.ReadKey();
    }
}
