using System;

class Program
{
    static void Main()
    {
       
        int N;
        do
        {
            Console.Write("Digite a ordem da matriz (máximo 100): ");
            N = int.Parse(Console.ReadLine());
        } while (N < 1 || N > 100);

       
        int[,] matriz = new int[N, N];
        PreencherMatriz(matriz);

        
        Console.WriteLine("\nMatriz Gerada:");
        ExibirMatriz(matriz);

        
        Console.WriteLine("\nDiagonal Secundária:");
        ExibirDiagonalSecundaria(matriz);
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

    
    static void ExibirDiagonalSecundaria(int[,] matriz)
    {
        int N = matriz.GetLength(0);
        for (int i = 0; i < N; i++)
        {
           
            Console.Write(matriz[i, N - i - 1] + "\t");
        }
        Console.WriteLine();
    }
}
