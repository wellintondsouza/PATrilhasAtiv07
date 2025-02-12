using System;

class Program
{
    static void Main()
    {
        // Definindo a matriz 10x10 com valores predefinidos
        int[,] matriz = new int[10, 10]
        {
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
            { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 },
            { 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 },
            { 31, 32, 33, 34, 35, 36, 37, 38, 39, 40 },
            { 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 },
            { 51, 52, 53, 54, 55, 56, 57, 58, 59, 60 },
            { 61, 62, 63, 64, 65, 66, 67, 68, 69, 70 },
            { 71, 72, 73, 74, 75, 76, 77, 78, 79, 80 },
            { 81, 82, 83, 84, 85, 86, 87, 88, 89, 90 },
            { 91, 92, 93, 94, 95, 96, 97, 98, 99, 100 }
        };

        int somaDiagonalPrincipal = 0;
        int somaDiagonalSecundaria = 0;

        // Impressão da matriz
        Console.WriteLine("Matriz 10x10:");
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Cálculo da soma e média da diagonal principal
        for (int i = 0; i < 10; i++)
        {
            somaDiagonalPrincipal += matriz[i, i];
        }
        double mediaDiagonalPrincipal = somaDiagonalPrincipal / 10.0;

        // Cálculo da soma e média da diagonal secundária
        for (int i = 0; i < 10; i++)
        {
            somaDiagonalSecundaria += matriz[i, 9 - i];
        }
        double mediaDiagonalSecundaria = somaDiagonalSecundaria / 10.0;

        Console.WriteLine($"\nSoma da Diagonal Principal: {somaDiagonalPrincipal}");
        Console.WriteLine($"Média da Diagonal Principal: {mediaDiagonalPrincipal}");
        Console.WriteLine($"Soma da Diagonal Secundária: {somaDiagonalSecundaria}");
        Console.WriteLine($"Média da Diagonal Secundária: {mediaDiagonalSecundaria}");
    }
}
