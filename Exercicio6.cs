using System;

class Program
{
    static void Main()
    {
        
        int N;
        do
        {
            Console.Write("Digite a ordem das matrizes (máximo 100): ");
            N = int.Parse(Console.ReadLine());
        } while (N < 1 || N > 100);

        
        int[,] matrizA = new int[N, N];
        int[,] matrizB = new int[N, N];
        PreencherMatriz(matrizA);
        PreencherMatriz(matrizB);

        
        Console.WriteLine("\nMatriz A:");
        ExibirMatriz(matrizA);

        Console.WriteLine("\nMatriz B:");
        ExibirMatriz(matrizB);

        
        if (VerificarOrdemMatrizes(matrizA, matrizB))
        {
            int[,] soma = SomarMatrizes(matrizA, matrizB);
            Console.WriteLine("\nSoma das Matrizes A e B:");
            ExibirMatriz(soma);
        }
        else
        {
            Console.WriteLine("\nAs matrizes não têm a mesma ordem, não é possível somá-las.");
        }
    }

    
    static void PreencherMatriz(int[,] matriz)
    {
        Random rand = new Random();
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = rand.Next(1, 101);  
            }
        }
    }

    
    static void ExibirMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    
    static bool VerificarOrdemMatrizes(int[,] matrizA, int[,] matrizB)
    {
        return matrizA.GetLength(0) == matrizB.GetLength(0) && matrizA.GetLength(1) == matrizB.GetLength(1);
    }

    
    static int[,] SomarMatrizes(int[,] matrizA, int[,] matrizB)
    {
        int N = matrizA.GetLength(0);
        int[,] soma = new int[N, N];

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                soma[i, j] = matrizA[i, j] + matrizB[i, j];
            }
        }

        return soma;
    }
}
