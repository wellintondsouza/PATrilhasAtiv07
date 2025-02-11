using System;

class Program
{
    public static void Main()
    {
       
        int[,] matriz = new int[3, 3];
        Random random = new Random();

        
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matriz[i, j] = random.Next(1, 101); // Gera um número aleatório entre 1 e 100
            }
        }

        // Exibindo a matriz
        Console.WriteLine("Matriz 3x3:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Encontrando o maior número na matriz
        int maiorNumero = matriz[0, 0];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (matriz[i, j] > maiorNumero)
                {
                    maiorNumero = matriz[i, j];
                }
            }
        }

        Console.WriteLine($"O maior número na matriz é: {maiorNumero}");
        Console.ReadKey();
    }
}
